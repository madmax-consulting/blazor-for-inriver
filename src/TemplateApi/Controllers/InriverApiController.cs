using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using TemplateShared;

namespace TemplateApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InriverApiController : ControllerBase
    {
        // Computer Vision Guide used: https://docs.microsoft.com/en-us/azure/cognitive-services/Computer-vision/quickstarts-sdk/client-library?pivots=programming-language-csharp&tabs=visual-studio

        public InriverApiController()
        {
        }

        [HttpGet]
        public async Task<ImageAnalysis> Get(int entityId, string inriverRestApiKey, string inriverRestApiBaseUrl, string computerVisionUrl, string computerVisionApiKey)
        {
            try
            {
                var inriverClient = new HttpClient() { BaseAddress = new Uri(inriverRestApiBaseUrl) };
                inriverClient.DefaultRequestHeaders.Add("X-inRiver-APIKey", inriverRestApiKey);

                var entitySummary = await inriverClient.GetFromJsonAsync<EntitySummary>($"entities/{entityId}/summary");
                if (entitySummary == null) return new ImageAnalysis();

                ComputerVisionClient client = Authenticate(computerVisionUrl, computerVisionApiKey);
                {
                    return await client.AnalyzeImageAsync(entitySummary.ResourceUrl, new List<VisualFeatureTypes?>
                    {VisualFeatureTypes.Adult
                        , VisualFeatureTypes.Brands, VisualFeatureTypes.Categories, VisualFeatureTypes.Color, VisualFeatureTypes.Description, VisualFeatureTypes.Faces, VisualFeatureTypes.ImageType, VisualFeatureTypes.Objects, VisualFeatureTypes.Tags}, new List<Details?>()
                    {
                        Details.Celebrities
                        , Details.Landmarks});
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        /// <summary>
        /// Authenticate to Computer Vision
        /// </summary>
        /// <param name="endpoint">Url for your own instance</param>
        /// <param name="key">Found under keys and endpoint in the azure portal</param>
        /// <returns></returns>
        private static ComputerVisionClient Authenticate(string endpoint, string key)
        {
            return new ComputerVisionClient(new ApiKeyServiceClientCredentials(key)) {Endpoint = endpoint};
        }
    }
}