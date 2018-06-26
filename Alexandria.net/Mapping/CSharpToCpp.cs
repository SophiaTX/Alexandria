﻿namespace Alexandria.net.Mapping
{
    /// <summary>
    /// 
    /// </summary>
    public class CSharpToCpp
    {
        private const string Vote = "vote";
        private const string AccountExists = "accountExists";
        private const string HasPrivateKeys = "hasPrivateKeys";
        private const string HasAccountOwnerPrivateKey = "hasAccountOwnerPrivateKey";
        private const string HasAccountActivePrivateKey = "hasAccountActivePrivateKey";
        private const string HasAccountMemoPrivateKey = "hasAccountMemoPrivateKey";
        private const string GetActiveAuthority = "getActiveAuthority";
        private const string GetOwnerAuthority = "getOwnerAuthority";
        private const string GetMemoKey = "getMemoKey";
        private const string GetAccountBalance = "getAccountBalance";
        private const string GetVestingBalance = "getVestingBalance";
        private const string CreateSimpleAuthority = "createSimpleAuthority";
        private const string CreateSimpleMultisigAuthority = "createSimpleMultisigAuthority";
        private const string CreateSimpleManagedAuthority = "createSimpleManagedAuthority";
        private const string CreateSimpleMultiManagedAuthority = "createSimpleMultiManagedAuthority";
        private const string UpdateAccount = "update_account";
        private const string DepositVesting = "depositVesting";
        private const string WithdrawVestings = "withdrawVestings";
        private const string VoteForWitness = "vote_for_witness";
        private const string UpdateToWitness = "updateToWitness";
        private const string GetAccount = "get_account";
        private const string CreateAccount = "create_account";
        private const string Transfer = "transfer";
        private const string GetAccountUiaBalance = "getAccountUiaBalance";
        private const string CreateUia = "createUia";
        private const string IssueUia = "issueUia";
        private const string BurnUia = "burnUia";
        private const string GetUiaAuthority = "getUiaAuthority";
        private const string HasUiaPrivateKey = "hasUiaPrivateKey";
        private const string DeleteAccount = "delete_account";
        private const string SuggestBrainKey = "suggest_brain_key";
        private const string NormalizeBrainKey = "normalize_brain_key";
        private const string About = "about";
        private const string Challenge = "challenge";
        private const string GetBlock = "get_block";
        private const string GetFeedHistory = "get_feed_history";
        private const string GetTransaction = "get_transaction";
        private const string BroadcastTransaction = "broadcast_transaction";
        private const string CreateSimpleTransaction = "create_simple_transaction";
        private const string CreateTransaction = "create_transaction";
        private const string PublishFeed = "publish_feed";
        private const string SetTransactionExpiration = "set_transaction_expiration";
        private const string SetVotingProxy = "set_voting_proxy";
        private const string WithdrawVesting = "withdraw_vesting";
        private const string TransferToVesting = "transfer_to_vesting";
        private const string GetOpsInBlock = "get_ops_in_block";
        private const string GetActiveWitnesses = "get_active_witnesses";
        private const string GetMinerQueue  = "get_miner_queue";
        private const string GetWitness  = "get_witness";
        private const string ListWitnesses  = "list_witnesses";
        private const string UpdateWitness  = "update_witness";
        private const string Help  = "help";
        private const string Info  = "info";
        private const string SerializeTransaction = "serialize_transaction";
        private const string MakeCustomJsonOperation = "make_custom_json_operation";
        private const string GetReceivedDocuments = "get_received_documents";
        private const string MakeCustomBinaryOperation = "make_custom_binary_operation";
        private const string CreateApplication = "create_application";
        private const string UpdateApplication = "update_application";
        private const string BuyApplication = "buy_application";
        private const string DeleteApplication = "delete_application";
        private const string CancelApplicationBuying = "cancel_application_buying";
        private const string GetApplicationBuyings = "get_application_buyings";
        private const string GetApplications = "get_applications";
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string GetValue(string value)
        {
            switch (value)
            {
                case "Vote":
                    return Vote;
                case "AccountExists":
                    return AccountExists;
                case "HasPrivateKeys":
                    return HasPrivateKeys;
                case "HasAccountOwnerPrivateKey":
                    return HasAccountActivePrivateKey;
                case "HasAccountMemoPrivateKey":
                    return HasAccountMemoPrivateKey;
                case "GetActiveAuthority":
                    return GetActiveAuthority;
                case "GetOwnerAuthority":
                    return GetOwnerAuthority;
                case "GetMemoKey":
                    return GetMemoKey;
                case "GetAccountBalance":
                    return GetAccountBalance;
                case "GetVestingBalance":
                    return GetVestingBalance;
                case "CreateSimpleAuthority":
                    return CreateSimpleAuthority;
                case "CreateSimpleMultisigAuthority":
                    return CreateSimpleMultisigAuthority;
                case "CreateSimpleManagedAuthority":
                    return CreateSimpleManagedAuthority;
                case "CreateSimpleMultiManagedAuthority":
                    return CreateSimpleMultiManagedAuthority;
                case "UpdateAccount":
                    return UpdateAccount;
                case "DepositVesting":
                    return DepositVesting;
                case "WithdrawVestings":
                    return WithdrawVestings;
                case "VoteForWitness":
                    return VoteForWitness;
                case "UpdateToWitness":
                    return UpdateToWitness;
                case "GetAccount":
                    return GetAccount;
                case "CreateAccount":
                    return CreateAccount;
                case "Transfer":
                    return Transfer;
                case "GetAccountUiaBalance":
                    return GetAccountUiaBalance;
                case "CreateUia":
                    return CreateUia;
                case "IssueUia":
                    return IssueUia;
                case "BurnUia":
                    return BurnUia;
                case "GetUiaAuthority":
                    return GetUiaAuthority;
                case "HasUiaPrivateKey":
                    return HasUiaPrivateKey;
                case "DeleteAccount":
                    return DeleteAccount;
                case "SuggestBrainKey":
                    return SuggestBrainKey;
                case "NormalizeBrainKey":
                    return NormalizeBrainKey;
                case "About":
                    return About;
                case "Challenge":
                    return Challenge;
                case "GetBlock":
                    return GetBlock;
                case "GetFeedHistory":
                    return GetFeedHistory;
                case "GetTransaction":
                    return GetTransaction;
                case "BroadcastTransaction":
                    return BroadcastTransaction;
                case "CreateSimpleTransactionTest":
                case "CreateSimpleTransaction":
                    return CreateSimpleTransaction;
                case "CreateTransaction":
                    return CreateTransaction;
                case "PublishFeed":
                    return PublishFeed;
                case "SetTransactionExpiration":
                    return SetTransactionExpiration;
                case "SetVotingProxy":
                    return SetVotingProxy;
                case "WithdrawVesting":
                    return WithdrawVesting;
                case "TransferToVesting":
                    return TransferToVesting;
                case "GetOpsInBlock":
                    return GetOpsInBlock;
                case "GetActiveWitnesses":
                    return GetActiveWitnesses;
                case "GetMinerQueue":
                    return GetMinerQueue;
                case "GetWitness":
                    return GetWitness;
                case "ListWitnesses":
                    return ListWitnesses;
                case "UpdateWitness":
                    return UpdateWitness;
                case "Help":
                    return Help;
                case "Info":
                    return Info;
                case "SerializeTransaction":
                    return SerializeTransaction;
                case "MakeCustomJsonOperation":
                    return MakeCustomJsonOperation;
                case "GetReceivedDocuments":
                    return GetReceivedDocuments;
                case "MakeCustomBinaryOperation":
                    return MakeCustomBinaryOperation;
                case "CreateApplication":
                    return CreateApplication ;
                case "DeleteApplication":
                    return DeleteApplication;
                case "UpdateApplication":
                    return UpdateApplication;
                case "BuyApplication":
                    return BuyApplication;
                case "CancelApplicationBuying":
                    return CancelApplicationBuying;
                case "GetApplicationBuyings":
                    return GetApplicationBuyings; 
                case "GetApplications":
                    return GetApplications;
            }

            return string.Empty;
        }
    }
}