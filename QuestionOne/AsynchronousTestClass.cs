using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    public class AsynchronousTestClass
    {
        public async Task<string> FetchDataFromAPI1()
        {
            return string.Empty; 
        }

        public async Task<string> FetchDataFromAPI2()
        {
            return string.Empty;
        }

        public async Task CallBothMethods()
        {
            var data = FetchDataFromAPI1();
            var data2 = FetchDataFromAPI2();
            Task.WhenAll(data, data2);
        }


        public async Task CallBothMethodsAny()
        {
            var data = FetchDataFromAPI1();
            var data2 = FetchDataFromAPI2();
            Task.WhenAny(data, data2);
        }
    }


}
