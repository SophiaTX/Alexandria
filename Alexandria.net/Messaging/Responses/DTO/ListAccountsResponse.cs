﻿using System.Collections.Generic;

namespace Alexandria.net.Messaging.Responses.DTO
{   
    public class ListAccountsResponse
    {
        public int id { get; set; }
        public List<string> result { get; set; }
    }
}