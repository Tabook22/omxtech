﻿using OmxTechNet.Models.DB;
using System.Collections.Generic;

namespace OmxTechNet.Models.ViewModel
{
    public class PostDataModel
    {
        public List<tbl_post> mPost { get; set; }
        public int PageSize { get; set; }
        public int TotalRecord { get; set; }
        public int NoOfPages { get; set; }
    }
}
