using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;

namespace WebApplication.Models
{
    public class ProHeaderViewModel
    {
        public long id { get; set; }
        public string title { get; set; }
        public Binary thumbnail { get; set; }
        public string description { get; set; }
        public string modified_by { get; set; }
        public string modified_date { get; set; }
        public List<ProDetailViewModel> details { get; set; }
    }

    public class ProDetailViewModel
    {
        public string row_number { get; set; }
        public Binary promo_file { get; set; }
        public string modified_by { get; set; }
        public string modified_date { get; set; }
    }

    public class ProHeaderInputModel
    {
        public long id { get; set; }
        public string title { get; set; }
        public Binary thumbnail { get; set; }
        public string description { get; set; }
        public string modified_by { get; set; }
        public string modified_date { get; set; }
        public List<ProDetailViewModel> details { get; set; }
    }

    public class ProDetailInputModel
    {
        public string row_number { get; set; }
        public Binary promo_file { get; set; }
    }

}