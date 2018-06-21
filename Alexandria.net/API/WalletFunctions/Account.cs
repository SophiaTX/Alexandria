﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Alexandria.net.Communication;
using Newtonsoft.Json;
using Alexandria.net.Logging;
using Alexandria.net.Messaging.Responses;
using Alexandria.net.Messaging.Responses.DTO;
using Alexandria.net.Settings;


namespace Alexandria.net.API.WalletFunctions
{
    /// <inheritdoc />
    /// <para>
    /// Wallet Account Functions 
    /// </para>
    public class Account : RpcConnection
    {
        private readonly ILogger _logger;

        #region Constructors

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        public Account(IConfig config) :
            base(config)
        {
            var assemblyname = Assembly.GetExecutingAssembly().GetName().Name;
            _logger = new Logger(LoggingType.Server, assemblyname);
        }

        #endregion

        /// <summary>
        /// Returns true if an account with given name exists.
        /// </summary>
        /// <param name="accountName">Input string accountName</param>
        /// <returns>Returns true if success and false for failed try</returns>
        public bool AccountExists(string accountName)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName};
                var result = SendRequest(reqname, @params);
                return result == "true";
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }
        }

        /// <summary>
        /// Returns true if the library has imported the private key corresponding to the given public key.
        /// </summary>
        /// <param name="key">Input byte[] key</param>
        /// <returns>Returns true if success and false for failed try</returns>
        public bool HasPrivateKeys(byte[] key)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {key};
                var result = SendRequest(reqname, @params);
                return result == "true";
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }
        }

        /// <summary>
        /// Returns true if the library has imported the private key corresponding to the account's owner key.In case of
        /// authorities consisting of more than one key(mutlisig), it returns true if and only if the library has
        /// sufificient keys to resolve the owner autority.
        /// </summary>
        /// <param name="accountName">Input string accountName</param>
        /// <returns>Returns true if success and false for failed try</returns>
        public bool HasAccountOwnerPrivateKey(string accountName)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName};
                var result = SendRequest(reqname, @params);
                return result == "true";
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Returns true if the library has imported the private key corresponding to the account's active key.In case of
        /// authorities consisting of more than one key(mutlisig), it returns true if and only if the library has
        /// sufficient keys to resolve the active autority.
        /// </summary>
        /// <param name="accountName">Input string accountName</param>
        /// <returns>Returns true if success and false for failed try</returns>
        public bool HasAccountActivePrivateKey(string accountName)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName};
                var result = SendRequest(reqname, @params);
                return result == "true";
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Returns true if the library has imported the private key corresponding to the account's memo key.
        /// </summary>
        /// <param name="accountName">Input string accountName</param>
        /// <returns>Returns true if success and false for failed try</returns>
        public bool HasAccountMemoPrivateKey(string accountName)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName};
                var result = SendRequest(reqname, @params);
                return result == "true";
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Returns the active authority of the given account.Object authority has the following structure:
        /// </summary>
        /// <param name="accountName">Input string accountName</param>
        /// <returns>Returns the Json object with the details about the active authority</returns>
        public Authority GetActiveAuthority(string accountName)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName};
                var result = SendRequest(reqname, @params);
                return JsonConvert.DeserializeObject<Authority>(result);
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }
        }

        /// <summary>
        /// Returns the owner authority of the given account.
        /// </summary>
        /// <param name="accountName">Input string accountName</param>
        /// <returns>Returns the Json object with the deails about the owner authority</returns>
        public Authority GetOwnerAuthority(string accountName)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName};
                var result = SendRequest(reqname, @params);
                return JsonConvert.DeserializeObject<Authority>(result);
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }
        }

        /// <summary>
        /// Returns the memo key of the given account.
        /// </summary>
        /// <param name="accountName">Input string accountName</param>
        /// <returns>Returns the Memo Key of the corresponding account</returns>
        public byte[] GetMemoKey(string accountName)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName};
                var result = SendRequest(reqname, @params);
                return JsonConvert.DeserializeObject<byte[]>(result);
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }


        /// <summary>
        /// Get SPHTX balance of the account.
        /// </summary>
        /// <param name="accountName">Input string accountName</param>
        /// <returns>Returns the account balance as a Json object</returns>
        public ulong GetAccountBalance(string accountName)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName};
                var result = SendRequest(reqname, @params);
                return JsonConvert.DeserializeObject<ulong>(result);
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Get SPHTX balance of the vesting account.
        /// </summary>
        /// <param name="accountName">Input string accountName</param>
        /// <returns>Returns the account balance as a Json object</returns>
        public ulong GetVestingBalance(string accountName)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName};
                var result = SendRequest(reqname, @params);
                return JsonConvert.DeserializeObject<ulong>(result);
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Creates authority resolvable with signature corresponding to the given pub_key.
        /// </summary>
        /// <param name="pubKey">Input byte[] pubKey</param>
        /// <returns>Returns Json object with details combining</returns>
        public Authority CreateSimpleAuthority(byte[] pubKey)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {pubKey};
                var result = SendRequest(reqname, @params);
                return JsonConvert.DeserializeObject<Authority>(result);
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Creates authority resolvable with given number of signatures out of the given set of keys.
        /// </summary>
        /// <param name="pubKeys">Input List of Byte[] pubKeys</param>
        /// <param name="requiredSignatures">Input ulong requiredSignatures</param>
        /// <returns>Returns Json object with details combining</returns>
        public Authority CreateSimpleMultisigAuthority(List<byte[]> pubKeys, ulong requiredSignatures)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {pubKeys, requiredSignatures};
                var result = SendRequest(reqname, @params);
                return JsonConvert.DeserializeObject<Authority>(result);
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Creates authority resolvable with a given managing account.
        /// </summary>
        /// <param name="managingAccountName">string managingAccountName</param>
        /// <returns>Returns Json object with details combining</returns>
        public Authority CreateSimpleManagedAuthority(string managingAccountName)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {managingAccountName};
                var result = SendRequest(reqname, @params);
                return JsonConvert.DeserializeObject<Authority>(result);
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Creates authority resolvable with given number of​ managing accounts.
        /// </summary>
        /// <param name="managingAccounts">Input List of string managingAccounts</param>
        /// <param name="requiredSignatures">Input uint requiredSignatures</param>
        /// <returns>Returns Json object with details combining</returns>
        public Authority CreateSimpleMultiManagedAuthority(List<string> managingAccounts, uint requiredSignatures)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {managingAccounts, requiredSignatures};
                var result = SendRequest(reqname, @params);
                return JsonConvert.DeserializeObject<Authority>(result);
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Update account authorities.
        /// </summary>
        /// <param name="accountName">Input string accountName</param>
        /// <param name="owner">Input Authority owner</param>
        /// <param name="active">Input Authority active</param>
        /// <param name="memo">Input byte[] memo</param>
        /// <returns>Returns true if success or false for failed try</returns>
        public bool UpdateAccount(string accountName, Authority owner, Authority active, byte[] memo)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName, owner, active, memo};
                var result = SendRequest(reqname, @params);
                return result == "true";
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Deposit to_vestings SPHTXs to vesting.
        /// </summary>
        /// <param name="accountName">Input string accountName</param>
        /// <param name="toVestings">Input ulong toVestings</param>
        /// <returns>Returns true if success or false for failed try</returns>
        public bool DepositVesting(string accountName, ulong toVestings)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName, toVestings};
                var result = SendRequest(reqname, @params);
                return result == "true";
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Withdraw from_vestings vested SPHTXs.
        /// </summary>
        /// <param name="accountName">Input string accountName</param>
        /// <param name="fromVestings">Input ulong fromVestings</param>
        /// <returns>Returns true if success or false for failed try</returns>
        public bool WithdrawVestings(string accountName, ulong fromVestings)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName, fromVestings};
                var result = SendRequest(reqname, @params);
                return result == "true";
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Vote or unvote a witness.
        /// </summary>
        /// <param name="votingAccountName">Input string votingAccountName</param>
        /// <param name="votedAccountName">Input string votedAccountName</param>
        /// <param name="approve">Input string approve</param>
        /// <returns></returns>
        public bool VoteForWitness(string votingAccountName, string votedAccountName, string approve)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {votingAccountName, votedAccountName, approve};
                var result = SendRequest(reqname, @params);
                return result == "true";
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Update an account to witness.Requires XXX vested SPHTX before updating.
        /// </summary>
        /// <param name="accountName">Inout string accountName</param>
        /// <param name="url">Input string url</param>
        /// <param name="blockKey">Input byte[] blockKey</param>
        /// <returns>Returns true if success or false for failed try</returns>
        public bool UpdateToWitness(string accountName, string url, byte[] blockKey)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName, url, blockKey};
                var result = SendRequest(reqname, @params);
                return result == "true";
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// Gets the account information
        /// </summary>
        /// <param name="accountName">the account name the information is required for</param>
        /// <returns>the account information</returns>
        public bool GetAccount(string accountName)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName};
                var result = SendRequest(reqname, @params);
                return result == "true";
            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="creator"></param>
        /// <param name="newname"></param>
        /// <param name="jsonMeta"></param>
        /// <param name="owner"></param>
        /// <param name="active"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        public CreateAccountResponse CreateAccount(string creator, string newname, string jsonMeta, string owner,
            string active, string memo)
        {
            var trans = new Transaction(Config);
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {creator, newname, jsonMeta, owner, active, memo};
                var result = SendRequest(reqname, @params);
                var contentdata = JsonConvert.DeserializeObject<CreateAccountResponse>(result);
                trans.create_simple_transaction(contentdata);
                return contentdata;

            }
            catch (Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void transfer_to_vesting()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Deletes the account from the blockchain related to the given name of the account
        /// </summary>
        /// <param name="accountName"></param>
        /// <returns>Returns object containing information about the new operation created</returns>
        public BlockResponse DeleteAccount(string accountName)
        {
            try
            {
                var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name.ToLower());
                var @params = new ArrayList {accountName};
                var result= SendRequest(reqname, @params);
                var contentdata = JsonConvert.DeserializeObject<BlockResponse>(result);
                
                return contentdata;
            }
            catch(Exception ex)
            {
                _logger.WriteError($"Message:{ex.Message} | StackTrace:{ex.StackTrace}");
                throw ;
            }
            
        }
    }
}