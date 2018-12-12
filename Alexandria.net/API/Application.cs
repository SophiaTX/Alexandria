﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Alexandria.net.Communication;
using Alexandria.net.Enums;
using Alexandria.net.Extensions;
using Alexandria.net.Input;
using Alexandria.net.Logging;
using Alexandria.net.Messaging.Responses;
using Alexandria.net.Settings;
using Newtonsoft.Json;

namespace Alexandria.net.API
{
    /// <inheritdoc />
    /// <para>
    /// WSophia Blockchain Wallet functions
    /// </para>
    public class Application:RpcConnection
    {
        private readonly ILogger _logger;

        #region constructor

        /// <summary>
        /// Application Constructor
        /// </summary>
        /// <param name="config"></param>
        /// <param name="wallet"></param>
        public Application(IConfig config, bool wallet = true) : base(config, wallet)
        {
            var assemblyname = Assembly.GetExecutingAssembly().GetName().Name;
            _logger = new Logger(config, assemblyname);
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///  This method will create new application object. There is a fee associated with account creation
        ///  that is paid by the creator. The current account creation fee can be found with the
        ///  'info' wallet command.
        /// </summary>
        /// <param name="author">The account creating the new application</param>
        /// <param name="appName">The unique name for new application</param>
        /// <param name="url">The url of the new application</param>
        /// <param name="metaData">The meta data of new application</param>
        /// <param name="priceParam">The price parameter that specifies billing for the app (1 or 0)</param>
        /// <param name="privateKey"></param>
        public BroadcastTxResponse CreateApplication(string author, string appName, string url, string metaData,
            byte priceParam, string privateKey)
        {
            var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name);
//            var @params = ParamHelper.GetValue(MethodBase.GetCurrentMethod().Name, author, appName, url, metaData,
//                priceParam);
            var @params = new CreateApplicationInput{author = author, app_name = appName, url = url, meta_data = metaData, price_param = priceParam};
            var result = SendRequestToDaemon(reqname, @params);
            var contentdata = JsonConvert.DeserializeObject<AccountResponse>(result);
            var response = StartBroadcasting(contentdata.Result, privateKey);
            return response;
        }


        /// <summary>
        /// This method will update existing application object.
        /// </summary>
        /// <param name="author">The author of application</param>
        /// <param name="appName">The name of app that will be updated</param>
        /// <param name="newAuthor">The new author</param>
        /// <param name="url">Updated url</param>
        /// <param name="metaData">Updated meta data</param>
        /// <param name="priceParam">Updated price param</param>
        /// <param name="privateKey"></param>
        public BroadcastTxResponse UpdateApplication(string author, string appName, string newAuthor, string url,
            string metaData, byte priceParam, string privateKey)
        {
            var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name);
//            var @params = ParamHelper.GetValue(MethodBase.GetCurrentMethod().Name, author, appName, newAuthor, url,
//                metaData, priceParam);
           
            var @params = new UpdateApplicationInput {author = author, app_name = appName, new_author = newAuthor, url = url, meta_data = metaData, price_param = priceParam};
            var result = SendRequestToDaemon(reqname, @params);
            var contentdata = JsonConvert.DeserializeObject<AccountResponse>(result);
            var response = StartBroadcasting(contentdata.Result, privateKey);
            return response;
        }

        /// <summary>
        /// This method will delete specified application object.
        /// </summary>
        /// <param name="author">The author of application that will be deleted</param>
        /// <param name="appName">The name of app that will be deleted</param>
        /// <param name="privateKey"></param>
        public BroadcastTxResponse DeleteApplication(string author, string appName, string privateKey)
        {
            var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name);
            //var @params = ParamHelper.GetValue(MethodBase.GetCurrentMethod().Name, author, appName);
            var @params = new DeleteApplicationInput {author = author, app_name = appName};
            var result = SendRequestToDaemon(reqname, @params);
            var contentdata = JsonConvert.DeserializeObject<AccountResponse>(result);
            var response = StartBroadcasting(contentdata.Result, privateKey);
            return response;
        }

        /// <summary>
        /// This method will create application buy object
        /// </summary>
        /// <param name="buyer">The buyer of application</param>
        /// <param name="appId">The id of app that buyer will buy</param>
        /// <param name="privateKey"></param>
        public BroadcastTxResponse BuyApplication(string buyer, long appId, string privateKey)
        {
            var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name);
            //var @params = ParamHelper.GetValue(MethodBase.GetCurrentMethod().Name, buyer, appId);
            var @params = new BuyApplicationInput {buyer = buyer, app_id = appId};
            var result = SendRequestToDaemon(reqname, @params);
            var contentdata = JsonConvert.DeserializeObject<AccountResponse>(result);
            var response = StartBroadcasting(contentdata.Result, privateKey);
            return response;
        }

        ///  <summary>
        ///  This method will cancel application buy object
        ///  </summary>
        ///  <param name="appOwner">The owner of bought application
        /// </param>
        ///  <param name="buyer">The buyer of application</param>
        ///  <param name="appId">The id of bought app</param>
        /// <param name="privateKey"></param>
        public BroadcastTxResponse CancelApplicationBuying(string appOwner, string buyer, long appId, string privateKey)
        {
            var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name);
            //var @params = ParamHelper.GetValue(MethodBase.GetCurrentMethod().Name, appOwner, buyer, appId);
            var @params = new CancelBuyingInput {app_owner = appOwner, buyer = buyer, app_id = appId};
            var result = SendRequestToDaemon(reqname, @params);
            var contentdata = JsonConvert.DeserializeObject<AccountResponse>(result);
            var response = StartBroadcasting(contentdata.Result, privateKey);
            return response;
        }

        /// <summary>
        /// Get all app buyings by app_name or buyer
        /// </summary>
        /// <param name="buyerName">the buyers name</param>
        /// <param name="searchType">search_type One of "by_buyer", "by_app_id"</param>
        /// <param name="count">count Number of items to retrieve</param>
        public ApplicationSearchResponse GetApplicationBuyings(string buyerName, SearchType searchType, uint count)
        {
            var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name);
//            var @params = ParamHelper.GetValue(MethodBase.GetCurrentMethod().Name, buyerName,
//                searchType.GetStringValue(), count);
            var @params = new GetApplicationBuyingInput {name = buyerName, search_type = searchType.GetStringValue(), count = count};
            var result = SendRequestToDaemon(reqname, @params);
            var contentdata = JsonConvert.DeserializeObject<ApplicationSearchResponse>(result);

            return contentdata;
        }

        /// <summary>
        /// Get list of published applications on the blockchain
        /// </summary>
        /// <param name="applicationNames">list of names of appictions to be searched</param>
        /// <returns>the application response data</returns>
        public GetApplicationResponse GetApplications(List<string> applicationNames)
        {
            var reqname = CSharpToCpp.GetValue(MethodBase.GetCurrentMethod().Name);
            //var @params = ParamHelper.GetValue(MethodBase.GetCurrentMethod().Name, applicationNames);
            var @params = new GetApplicationsInput {names = applicationNames};
            var result= SendRequestToDaemon(reqname, @params);
            var response = JsonConvert.DeserializeObject<GetApplicationResponse>(result);

            return response;
        }
        #endregion
    }
}