namespace DP_SOLID
{
    class SingleResponsibility
    {
        public class Website
        {
            public string Link { get; set; }
            public string ProtocolName { get; set; }

            public string PortNumber { get; set; }
        }
        public static class WebsiteValidation
        {
            public static bool IsThisWebsite(string link, string protocol, string port) {
                //validation code
                return true;
            }
        }

        public class ActivatedSite
        {
            public bool Activated(Website website) {
                if (WebsiteValidation.IsThisWebsite(website.Link,website.ProtocolName,website.PortNumber))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
