using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace WStoreNETAPI
{
    class apiRead
    {
        public static string getResponse { get; set; }
        public static async Task getOrders(string apikey)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://api.w-store.org/orders/queue/" + apikey))
                {
                    var response = await httpClient.SendAsync(request);
                    string getResponse = await response.Content.ReadAsStringAsync();
                    if (getResponse.Contains(Errors.noInfo))
                    {
                        Errors.NoOrders();
                    }
                    if (getResponse.Contains(Errors.invalidHS))
                    {
                        Errors.InvalidHandshake();
                    }
                    else
                    {
                        MessageBox.Show(getResponse, "W-STORE | API");
                    }
                }
            }
        }
        public static async Task getTopCustomer(string apikey)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.w-store.org/stores"))
                {
                    var multipartContent = new MultipartFormDataContent();
                    multipartContent.Add(new StringContent(apikey), "api_key");
                    multipartContent.Add(new StringContent("getModule"), "action");
                    multipartContent.Add(new StringContent("topCustomer"), "module");
                    request.Content = multipartContent;

                    var response = await httpClient.SendAsync(request);
                    string getResponse = await response.Content.ReadAsStringAsync();
                    if (getResponse.Contains(Errors.noInfo))
                    {
                        Errors.NoOrders();
                    }
                    if (getResponse.Contains(Errors.invalidHS))
                    {
                        Errors.InvalidHandshake();
                    }
                    else
                    {
                        MessageBox.Show(getResponse, "W-STORE | API");
                    }
                }
            }
        }
        public static async Task getrecentTopCustomer(string apikey)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.w-store.org/stores"))
                {
                    var multipartContent = new MultipartFormDataContent();
                    multipartContent.Add(new StringContent(apikey), "api_key");
                    multipartContent.Add(new StringContent("getModule"), "action");
                    multipartContent.Add(new StringContent("recentTopCustomers"), "module");
                    request.Content = multipartContent;

                    var response = await httpClient.SendAsync(request);
                    string getResponse = await response.Content.ReadAsStringAsync();
                    if (getResponse.Contains(Errors.noInfo))
                    {
                        Errors.NoOrders();
                    }
                    if (getResponse.Contains(Errors.invalidHS))
                    {
                        Errors.InvalidHandshake();
                    }
                    else
                    {
                        MessageBox.Show(getResponse, "W-STORE | API");
                    }
                }
            }
        }
        public static async Task getRecentPayments(string apikey)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.w-store.org/stores"))
                {
                    var multipartContent = new MultipartFormDataContent();
                    multipartContent.Add(new StringContent(apikey), "api_key");
                    multipartContent.Add(new StringContent("getModule"), "action");
                    multipartContent.Add(new StringContent("recentPayments"), "module");
                    request.Content = multipartContent;

                    var response = await httpClient.SendAsync(request);
                    string getResponse = await response.Content.ReadAsStringAsync();
                    if (getResponse.Contains(Errors.noInfo))
                    {
                        Errors.NoOrders();
                    }
                    if (getResponse.Contains(Errors.invalidHS))
                    {
                        Errors.InvalidHandshake();
                    }
                    else
                    {
                        MessageBox.Show(getResponse, "W-STORE | API");
                    }
                }
            }
        }
        public static async Task getGoal(string apikey)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.w-store.org/stores"))
                {
                    var multipartContent = new MultipartFormDataContent();
                    multipartContent.Add(new StringContent(apikey), "api_key");
                    multipartContent.Add(new StringContent("getModule"), "action");
                    multipartContent.Add(new StringContent("goal"), "module");
                    request.Content = multipartContent;

                    var response = await httpClient.SendAsync(request);
                    string getResponse = await response.Content.ReadAsStringAsync();
                    if (getResponse.Contains(Errors.noInfo))
                    {
                        Errors.NoOrders();
                    }
                    if (getResponse.Contains(Errors.invalidHS))
                    {
                        Errors.InvalidHandshake();
                    }
                    else
                    {
                        MessageBox.Show(getResponse, "W-STORE | API");
                    }
                }
            }
        }
        public static async Task getRecommendedProduct(string apikey)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.w-store.org/stores"))
                {
                    var multipartContent = new MultipartFormDataContent();
                    multipartContent.Add(new StringContent(apikey), "api_key");
                    multipartContent.Add(new StringContent("getModule"), "action");
                    multipartContent.Add(new StringContent("recommendedProduct"), "module");
                    request.Content = multipartContent;

                    var response = await httpClient.SendAsync(request);
                    string getResponse = await response.Content.ReadAsStringAsync();
                    if (getResponse.Contains(Errors.noInfo))
                    {
                        Errors.NoOrders();
                    }
                    if (getResponse.Contains(Errors.invalidHS))
                    {
                        Errors.InvalidHandshake();
                    }
                    else
                    {
                        MessageBox.Show(getResponse, "W-STORE | API");
                    }
                }
            }
        }
        public static async Task getProductByID(string apikey)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.w-store.org/stores"))
                {
                    var multipartContent = new MultipartFormDataContent();
                    multipartContent.Add(new StringContent(apikey), "api_key");
                    multipartContent.Add(new StringContent("getProduct"), "action");
                    multipartContent.Add(new StringContent("product_id"), "module");
                    request.Content = multipartContent;

                    var response = await httpClient.SendAsync(request);
                    string getResponse = await response.Content.ReadAsStringAsync();
                    if (getResponse.Contains(Errors.noInfo))
                    {
                        Errors.NoOrders();
                    }
                    if (getResponse.Contains(Errors.invalidHS))
                    {
                        Errors.InvalidHandshake();
                    }
                    else
                    {
                        MessageBox.Show(getResponse, "W-STORE | API");
                    }
                }
            }
        }
        public static async Task getProductByCategoryID(string apikey)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.w-store.org/stores"))
                {
                    var multipartContent = new MultipartFormDataContent();
                    multipartContent.Add(new StringContent(apikey), "api_key");
                    multipartContent.Add(new StringContent("getProductsInCategory"), "action");
                    multipartContent.Add(new StringContent("category_id"), "module");
                    request.Content = multipartContent;

                    var response = await httpClient.SendAsync(request);
                    string getResponse = await response.Content.ReadAsStringAsync();
                    if (getResponse.Contains(Errors.noInfo))
                    {
                        Errors.NoOrders();
                    }
                    if (getResponse.Contains(Errors.invalidHS))
                    {
                        Errors.InvalidHandshake();
                    }
                    else
                    {
                        MessageBox.Show(getResponse, "W-STORE | API");
                    }
                }
            }
        }
    }
}