using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class General
    {
        public static class ProcessType
        {
            public static int Login = 1;
            public static int AddressWasAdded = 2;
            public static int AddressWasUpdated = 3;
            public static int AddressWasDeleted = 4;
            public static int AdsWasAdded = 5;
            public static int AdsWasUpdated = 6;
            public static int AdsWasDeleted = 7;
            public static int CategoryWasAdded = 8;
            public static int CategoryWasUpdated = 9;
            public static int CategoryWasDeleted = 10;
            public static int IconFavLogoWasAdded = 11;
            public static int IconFavLogoWasUpdated = 12;
            public static int IconFavLogoWasDeleted = 13;
            public static int MetaWasAdded = 14;
            public static int MetaWasUpdated = 15;
            public static int MetaWasDeleted = 16;
            public static int SocialMediaWasAdded = 17;
            public static int SocialMediaWasUpdated = 18;
            public static int SocialMediaWasDeleted = 19;
            public static int UserWasAdded = 20;
            public static int UserWasUpdated = 21;
            public static int UserWasDeleted = 22;
            public static int VideoMediaWasAdded = 23;
            public static int VideoMediaWasUpdated = 24;
            public static int VideoMediaWasDeleted = 25;
            public static int PostWasAdded = 26;
            public static int PostWasUpdated = 27;
            public static int PostWasDeleted = 28;
            public static int ImageWasAdded = 29;
            public static int ImageWasUpdated = 30;
            public static int ImageWasDeleted = 31;
            public static int TagMediaWasAdded = 32;
            public static int TagMediaWasUpdated = 33;
            public static int TagMediaWasDeleted = 34;
            public static int CommentApproved = 35;
            public static int CommentWasDeleted = 36;
            public static int ContractWasRead = 37;
            public static int ContactWasDeleted = 38;
        }

        public static class TableName
        {
            public static string Login = "Login";
            public static string Address = "Address";
            public static string Ads = "Ads";
            public static string Category = "Category";
            public static string Icon = "IconFavTitle";
            public static string Meta = "Meta";
            public static string Social = "Social Media";
            public static string User = "User";
            public static string Video = "Video";
            public static string Post = "Post";
            public static string Image = "Image";
            public static string Tag = "Tag";
            public static string Commnet = "Commnet";
            public static string Contact = "Contact";
        }
    }
}
