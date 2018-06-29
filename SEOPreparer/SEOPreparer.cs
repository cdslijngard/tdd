using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEO
{
    public class SEOPreparer
    {
        public SEOPreparer()
        {

        }

        private static String[] unnecessaryWords = new String[] { "this", "and", "the", "a", "an" };

        public String[] PrepareQuery(string searchString)
        {
            searchString = searchString.ToLower();

            String[] queryParams = searchString.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            queryParams = queryParams.Where(s => !unnecessaryWords.Contains(s)).ToArray();
            queryParams = queryParams.Distinct().ToArray();
            return queryParams;
        }
    }
}
