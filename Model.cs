using System;

namespace Model
{
    public class UserUnfo
    {
        public string userName {get;set;}
        public string passWord {get;set;}
        public string qq {get;set;}
        public string email {get;set;}
        public string type {get;set;}
        public string userImg { get; set; }
    }
    public class UserUnfoNo : UserUnfo
    {
        public int num { get; set; }
    }
    public class Page {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
