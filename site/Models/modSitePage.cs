﻿namespace SITE.ITEGAMAX._4._0._2.Models
{
    public class modSitePage
    {

        public int pageId { get; set; }
        public string? pageurlid { get; set; }
        public string? pagetitle { get; set; }
        public string? pagesubtitle { get; set; }
        public string? pageshortdescription { get; set; }
        public string? pagelayoutname { get; set; }
        public int pagecategoryid { get; set; }
        public string? pagetopbannerpic { get; set; }
        public string? pagetopbannertitle { get; set; }
        public string? pagetopbannersubtitle { get; set; }
        public string? pagetopbannertext { get; set; }
        public string? pagemediumbannerpic { get; set; }
        public string? pagemediumbannertitle { get; set; }
        public string? pagemediumbannersubtitle { get; set; }
        public string? pagemediumbannertext { get; set; }
        public string? pagesmallbannerpic { get; set; }
        public string? pagesmallbannertitle { get; set; }
        public string? pagesmallbannersubtitle { get; set; }
        public string? pagesmallbannertext { get; set; }
        public string? pagemodifieddate { get; set; }
        public string? pagecreateddate { get; set; }
        public string? pageupdateddate { get; set; }
        public int pagetype { get; set; }
        public int pagestatus { get; set; }
        public int pagemenuarea { get; set; }
        public string? pageareaname { get; set; }
        public string? pageareapath { get; set; }
        public int? viewcount { get; set; }


        public List<modSitePageArticle>? Articles { get; set; }

        public modSiteMetaTags? SiteMetaTags { get; set; }


    }
}
