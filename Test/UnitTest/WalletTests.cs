using System;
using Alexandria.net.Logging;
using Xunit;


namespace UnitTest
{
    public class WalletTests : BaseTest
    {
        private const string Transaction =
            "{ \"ref_block_num\": 287,\"ref_block_prefix\": 3535709865,\"expiration\": \"2018-06-01T07:42:27\",\"operations\": [[\"account_create\",{\"fee\": \"0.000030 SPHTX\",\"creator\": \"initminer\",\"new_account_name\": \"matus\",\"owner\": {\"weight_threshold\": 1,\"account_auths\": [],\"key_auths\": [[\"STM5WcWH1RAUd2sJK4eNJxomZuf6RAjs1s6CB4sfkQcHaaS3JY66f\",1 ]]},\"active\": {\"weight_threshold\": 1,\"account_auths\": [],\"key_auths\": [[\"STM8JCyWEwLUypREhAadUxKVWSzTyhUvNW8XiYppnZN31sBpMXUt8\",1]]},\"memo_key\": \"STM5sSw5xWuEYQf1EUoCsD6uUHuGgA6orAC4var1Kka28BL2j3wiL\",\"json_metadata\": \"{}\"}]],\"extensions\": [],\"signatures\": [],\"transaction_id\": \"560f5b91130e4048dbc6a6d4b2d1e0093b412a83\",\"block_num\": 0,\"transaction_num\": 0}";

        private readonly string _digest="560f5b91130e4048dbc6a6d4b2d1e0093b412a83a529c36d7066";
        private readonly string _sign="1f05e0a0ad257dd3f93fb01cacf8da5da2e1a632d6da4f1eb35506a3e5a854f8ff1ff42e725f0caac288226e29b7138bd02a3389b3fb4aab4b92cd9f3f0773e96";
        private readonly string _key="5KfQMLDj6QkiGV515xb42GzB6PqS4aGGefBYxZwWvuazsW1AYrj";
        private readonly string _signedTransaction =  "{ \"ref_block_num\": 287,\"ref_block_prefix\": 3535709865,\"expiration\": \"2018-06-01T07:42:27\",\"operations\": [[\"account_create\",{\"fee\": \"0.000030 SPHTX\",\"creator\": \"initminer\",\"new_account_name\": \"matus\",\"owner\": {\"weight_threshold\": 1,\"account_auths\": [],\"key_auths\": [[\"STM5WcWH1RAUd2sJK4eNJxomZuf6RAjs1s6CB4sfkQcHaaS3JY66f\",1 ]]},\"active\": {\"weight_threshold\": 1,\"account_auths\": [],\"key_auths\": [[\"STM8JCyWEwLUypREhAadUxKVWSzTyhUvNW8XiYppnZN31sBpMXUt8\",1]]},\"memo_key\": \"STM5sSw5xWuEYQf1EUoCsD6uUHuGgA6orAC4var1Kka28BL2j3wiL\",\"json_metadata\": \"{}\"}]],\"extensions\": [],\"signatures\": [\"1f05e0a0ad257dd3f93fb01cacf8da5da2e1a632d6da4f1eb35506a3e5a854f8ff1ff42e725f0caac288226e29b7138bd02a3389b3fb4aab4b92cd9f3f0773e96\"],\"transaction_id\": \"560f5b91130e4048dbc6a6d4b2d1e0093b412a83\",\"block_num\": 0,\"transaction_num\": 0}";

        
        
        [Fact]
        public void VoteForWitness()
        {
            _client.Wallet.Witness.Vote("initminer","temp",true); //{"id":0,"error":{"code":1,"message":"0 exception: unspecified\nmissing required active authority:Missing Active Authority initminer\n    {\"error\":\"missing required active authority:Missing Active Authority initminer\",\"data\":{\"id\":3,\"error\":{\"code\":-32000,\"message\":\"missing required active authority:Missing Active Authority initminer\",\"data\":{\"code\":3010000,\"name\":\"tx_missing_active_auth\",\"message\":\"missing required active authority\",\"stack\":[{\"context\":{\"level\":\"error\",\"file\":\"transaction_util.hpp\",\"line\":45,\"method\":\"verify_authority\",\"hostname\":\"\",\"timestamp\":\"2018-06-13T07:04:09\"},\"format\":\"Missing Active Authority ${id}\",\"data\":{\"id\":\"initminer\",\"auth\":{\"weight_threshold\":1,\"account_auths\":[],\"key_auths\":[[\"STM8Xg6cEbqPCY8jrWFccgbCq5Fjw1okivwwmLDDgqQCQeAk7jedu\",1]]},\"owner\":{\"weight_threshold\":1,\"account_auths\":[],\"key_auths\":[[\"STM8Xg6cEbqPCY8jrWFccgbCq5Fjw1okivwwmLDDgqQCQeAk7jedu\",1]]}}},{\"context\":{\"level\":\"warn\",\"file\":\"transaction_util.hpp\",\"line\":60,\"method\":\"verify_authority\",\"hostname\":\"\",\"timestamp\":\"2018-06-13T07:04:09\"},\"format\":\"\",\"data\":{\"auth_containers\":[[\"account_witness_vote\",{\"account\":\"initminer\",\"witness\":\"temp\",\"approve\":true}]],\"sigs\":[]}},{\"context\":{\"level\":\"warn\",\"file\":\"transaction.cpp\",\"line\":169,\"method\":\"verify_authority\",\"hostname\":\"\",\"timestamp\":\"2018-06-13T07:04:09\"},\"format\":\"\",\"data\":{\"*this\":{\"ref_block_num\":19802,\"ref_block_prefix\":746503726,\"expiration\":\"2018-06-13T07:04:39\",\"operations\":[[\"account_witness_vote\",{\"account\":\"initminer\",\"witness\":\"temp\",\"approve\":true}]],\"extensions\":[],\"signatures\":[]}}},{\"context\":{\"level\":\"warn\",\"file\":\"database.cpp\",\"line\":2112,\"method\":\"_apply_transaction\",\"hostname\":\"\",\"timestamp\":\"2018-06-13T07:04:09\"},\"format\":\"\",\"data\":{\"trx\":{\"ref_block_num\":19802,\"ref_block_prefix\":746503726,\"expiration\":\"2018-06-13T07:04:39\",\"operations\":[[\"account_witness_vote\",{\"account\":\"initminer\",\"witness\":\"temp\",\"approve\":true}]],\"extensions\":[],\"signatures\":[]}}},{\"context\":{\"level\":\"warn\",\"file\":\"database.cpp\",\"line\":654,\"method\":\"push_transaction\",\"hostname\":\"\",\"timestamp\":\"2018-06-13T07:04:09\"},\"format\":\"\",\"data\":{\"trx\":{\"ref_block_num\":19802,\"ref_block_prefix\":746503726,\"expiration\":\"2018-06-13T07:04:39\",\"operations\":[[\"account_witness_vote\",{\"account\":\"initminer\",\"witness\":\"temp\",\"approve\":true}]],\"extensions\":[],\"signatures\":[]}}}]}}}}\n    state.cpp:38 handle_reply\n\n    {\"voting_account\":\"initminer\",\"witness_to_vote_for\":\"temp\",\"approve\":true,\"broadcast\":true}\n    wallet.cpp:1455 vote_for_witness\n\n    {\"call.method\":\"vote_for_witness\",\"call.params\":[\"initminer\",\"temp\",true,true]}\n    websocket_api.cpp:138 on_message","data":{"code":0,"name":"exception","message":"unspecified","stack":[{"context":{"level":"error","file":"state.cpp","line":38,"method":"handle_reply","hostname":"","timestamp":"2018-06-13T07:04:09"},"format":"${error}","data":{"error":"missing required active authority:Missing Active Authority initminer","data":{"id":3,"error":{"code":-32000,"message":"missing required active authority:Missing Active Authority initminer","data":{"code":3010000,"name":"tx_missing_active_auth","message":"missing required active authority","stack":[{"context":{"level":"error","file":"transaction_util.hpp","line":45,"method":"verify_authority","hostname":"","timestamp":"2018-06-13T07:04:09"},"format":"Missing Active Authority ${id}","data":{"id":"initminer","auth":{"weight_threshold":1,"account_auths":[],"key_auths":[["STM8Xg6cEbqPCY8jrWFccgbCq5Fjw1okivwwmLDDgqQCQeAk7jedu",1]]},"owner":{"weight_threshold":1,"account_auths":[],"key_auths":[["STM8Xg6cEbqPCY8jrWFccgbCq5Fjw1okivwwmLDDgqQCQeAk7jedu",1]]}}},{"context":{"level":"warn","file":"transaction_util.hpp","line":60,"method":"verify_authority","hostname":"","timestamp":"2018-06-13T07:04:09"},"format":"","data":{"auth_containers":[["account_witness_vote",{"account":"initminer","witness":"temp","approve":true}]],"sigs":[]}},{"context":{"level":"warn","file":"transaction.cpp","line":169,"method":"verify_authority","hostname":"","timestamp":"2018-06-13T07:04:09"},"format":"","data":{"*this":{"ref_block_num":19802,"ref_block_prefix":746503726,"expiration":"2018-06-13T07:04:39","operations":[["account_witness_vote",{"account":"initminer","witness":"temp","approve":true}]],"extensions":[],"signatures":[]}}},{"context":{"level":"warn","file":"database.cpp","line":2112,"method":"_apply_transaction","hostname":"","timestamp":"2018-06-13T07:04:09"},"format":"","data":{"trx":{"ref_block_num":19802,"ref_block_prefix":746503726,"expiration":"2018-06-13T07:04:39","operations":[["account_witness_vote",{"account":"initminer","witness":"temp","approve":true}]],"extensions":[],"signatures":[]}}},{"context":{"level":"warn","file":"database.cpp","line":654,"method":"push_transaction","hostname":"","timestamp":"2018-06-13T07:04:09"},"format":"","data":{"trx":{"ref_block_num":19802,"ref_block_prefix":746503726,"expiration":"2018-06-13T07:04:39","operations":[["account_witness_vote",{"account":"initminer","witness":"temp","approve":true}]],"extensions":[],"signatures":[]}}}]}}}}},{"context":{"level":"warn","file":"wallet.cpp","line":1455,"method":"vote_for_witness","hostname":"","timestamp":"2018-06-13T07:04:09"},"format":"","data":{"voting_account":"initminer","witness_to_vote_for":"temp","approve":true,"broadcast":true}},{"context":{"level":"warn","file":"websocket_api.cpp","line":138,"method":"on_message","hostname":"","timestamp":"2018-06-13T07:04:09"},"format":"","data":{"call.method":"vote_for_witness","call.params":["initminer","temp",true,true]}}]}}}
        }
        
        [Fact]
        public void WithdrawVesting()
        {
            _client.Wallet.Transaction.withdraw_vesting("initminer",10); //add some shares for vesting test
        }
        
        [Fact]
        public void GetActiveWitness()
        {
            _client.Wallet.Witness.get_active_witnesses();
        }
        
        [Fact]
        public void GetFeedHistory()
        {
            _client.Wallet.Transaction.get_feed_history();
        }
        
        [Fact]
        public void CreateAccount()
        {
            _client.Wallet.Account.CreateAccount("initminer","sanjiv","{}");
        }
        [Fact]
        public void GetAccountBalance()
        {
            _client.Wallet.Account.GetAccount("sanjiv");
        }
        [Fact]
        public void CreateSimpleAuthority()
        {
            //_client.Wallet.Account.createSimpleAuthority();
        }

        [Fact]
        public void GetAbout()
        {
            _client.Wallet.Transaction.About();
        }
        
        [Fact]
        public void GetBlock()
        {
            var result = _client.Wallet.Transaction.get_block(8198);
            Console.WriteLine(result);
        } 
//        [Fact]
//       public void CreateSimpleAuthority(byte[] pubKey)
//       {
//          _client.Wallet.Account.createAccount("initminer","newaccount","{}",true);//{"id":0,"error":{"code":1,"message":"10 assert_exception: Assert Exception\napproving_account_objects.size() == v_approving_account_names.size(): \n    {\"aco.size:\":0,\"acn\":1}\n    wallet.cpp:573 sign_transaction\n\n    {\"creator\":\"creator\",\"new_account_name\":\"newaccount\",\"json_meta\":\"{}\",\"owner\":\"STM5piKvNaif6LrbscRka2EcP966QxLqEQZsqgov8KuwpXDsD2twV\",\"active\":\"STM67jBS4Hcrtg6EH811yMoCxq134Go6eUf5zxnsyR5qHhR3szGuo\",\"memo\":\"STM63Wv9vRvhVHwYHTpGR8F4ZLUh2m8nzkunK3RS24cG9SnJ4AsC9\",\"broadcast\":true}\n    wallet.cpp:1088 create_account_with_keys\n\n    {\"creator\":\"creator\",\"new_account_name\":\"newaccount\",\"json_meta\":\"{}\"}\n    wallet.cpp:1405 create_account\n\n    {\"call.method\":\"create_account\",\"call.params\":[\"creator\",\"newaccount\",\"{}\",true]}\n    websocket_api.cpp:138 on_message","data":{"code":10,"name":"assert_exception","message":"Assert Exception","stack":[{"context":{"level":"error","file":"wallet.cpp","line":573,"method":"sign_transaction","hostname":"","timestamp":"2018-06-13T07:25:37"},"format":"approving_account_objects.size() == v_approving_account_names.size(): ","data":{"aco.size:":0,"acn":1}},{"context":{"level":"warn","file":"wallet.cpp","line":1088,"method":"create_account_with_keys","hostname":"","timestamp":"2018-06-13T07:25:37"},"format":"","data":{"creator":"creator","new_account_name":"newaccount","json_meta":"{}","owner":"STM5piKvNaif6LrbscRka2EcP966QxLqEQZsqgov8KuwpXDsD2twV","active":"STM67jBS4Hcrtg6EH811yMoCxq134Go6eUf5zxnsyR5qHhR3szGuo","memo":"STM63Wv9vRvhVHwYHTpGR8F4ZLUh2m8nzkunK3RS24cG9SnJ4AsC9","broadcast":true}},{"context":{"level":"warn","file":"wallet.cpp","line":1405,"method":"create_account","hostname":"","timestamp":"2018-06-13T07:25:37"},"format":"","data":{"creator":"creator","new_account_name":"newaccount","json_meta":"{}"}},{"context":{"level":"warn","file":"websocket_api.cpp","line":138,"method":"on_message","hostname":"","timestamp":"2018-06-13T07:25:37"},"format":"","data":{"call.method":"create_account","call.params":["creator","newaccount","{}",true]}}]}}}
//       }
//       [Fact]
//       public void CreateAccount()
//       {
//          _client.Wallet.Account.createAccount("initminer","newaccount","{}",true);//{"id":0,"error":{"code":1,"message":"10 assert_exception: Assert Exception\napproving_account_objects.size() == v_approving_account_names.size(): \n    {\"aco.size:\":0,\"acn\":1}\n    wallet.cpp:573 sign_transaction\n\n    {\"creator\":\"creator\",\"new_account_name\":\"newaccount\",\"json_meta\":\"{}\",\"owner\":\"STM5piKvNaif6LrbscRka2EcP966QxLqEQZsqgov8KuwpXDsD2twV\",\"active\":\"STM67jBS4Hcrtg6EH811yMoCxq134Go6eUf5zxnsyR5qHhR3szGuo\",\"memo\":\"STM63Wv9vRvhVHwYHTpGR8F4ZLUh2m8nzkunK3RS24cG9SnJ4AsC9\",\"broadcast\":true}\n    wallet.cpp:1088 create_account_with_keys\n\n    {\"creator\":\"creator\",\"new_account_name\":\"newaccount\",\"json_meta\":\"{}\"}\n    wallet.cpp:1405 create_account\n\n    {\"call.method\":\"create_account\",\"call.params\":[\"creator\",\"newaccount\",\"{}\",true]}\n    websocket_api.cpp:138 on_message","data":{"code":10,"name":"assert_exception","message":"Assert Exception","stack":[{"context":{"level":"error","file":"wallet.cpp","line":573,"method":"sign_transaction","hostname":"","timestamp":"2018-06-13T07:25:37"},"format":"approving_account_objects.size() == v_approving_account_names.size(): ","data":{"aco.size:":0,"acn":1}},{"context":{"level":"warn","file":"wallet.cpp","line":1088,"method":"create_account_with_keys","hostname":"","timestamp":"2018-06-13T07:25:37"},"format":"","data":{"creator":"creator","new_account_name":"newaccount","json_meta":"{}","owner":"STM5piKvNaif6LrbscRka2EcP966QxLqEQZsqgov8KuwpXDsD2twV","active":"STM67jBS4Hcrtg6EH811yMoCxq134Go6eUf5zxnsyR5qHhR3szGuo","memo":"STM63Wv9vRvhVHwYHTpGR8F4ZLUh2m8nzkunK3RS24cG9SnJ4AsC9","broadcast":true}},{"context":{"level":"warn","file":"wallet.cpp","line":1405,"method":"create_account","hostname":"","timestamp":"2018-06-13T07:25:37"},"format":"","data":{"creator":"creator","new_account_name":"newaccount","json_meta":"{}"}},{"context":{"level":"warn","file":"websocket_api.cpp","line":138,"method":"on_message","hostname":"","timestamp":"2018-06-13T07:25:37"},"format":"","data":{"call.method":"create_account","call.params":["creator","newaccount","{}",true]}}]}}}
//       }
        [Fact]
        public void GeneratePrivateKey()
        {                     
            _client.Wallet.Key.generate_private_key_c(new byte[51],new byte[53]);      
        }
        [Fact]
        public void GetTransactionDigest()
        {           
           _client.Wallet.Key.get_transaction_digest_c(Transaction,new byte[64]);
             
        }
        [Fact]
        public void SignedDigest()
        {           
            _client.Wallet.Key.sign_digest_c(_digest,_key,new byte[130]);
            
        }
        [Fact]
        public void AddSignature()
        {           
            _client.Wallet.Key.add_signature_c(Transaction,_sign,new byte[Transaction.Length+200]);
            
        }
        [Fact]
        public void BroadcastTransaction()
        {
            _client.Wallet.Transaction.broadcast_transaction(_signedTransaction);

        }
        [Fact]
        public void ListKeys()
        {
            _client.Wallet.Key.list_keys();

        }
    }
}