# Blazor as a template engine for inriver
This project contains an example on how to write templates in .NET 5 using premade component libraries

## Your HTML template

```
<iframe  frameborder="0" scrolling="yes" seamless="seamless" style="display:block; width:100%; height:100vh;" name="blazor"></iframe>
	     <script>      
     var site = "https://templateapp.azurewebsites.net/?entityId=" + data[0].id + "&inriverRestApiKey=-------------&inriverRestApiBaseUrl=https://apieuw.productmarketingcloud.com/api/v1.0.0/&computerVisionUrl=https://your-computer-vision-url.cognitiveservices.azure.com/&computerVisionApiKey==-------------&&templateApiUrl=https://templateapi.azurewebsites.net";
      	window.onInRiverTemplateReady = function() {
    document.getElementsByName('blazor')[0].src = site;
        }
    </script>  

```
## Component Libraries
The suggested library is Syncfusion which is free in some cases, and has great documentation
Generate a key and add it to Program.cs
https://medium.com/@alexandre.malavasi/top-10-nice-free-blazor-components-b42875e56b28 
Has more libraries that are good

## Computer Vision API
Create a computer vision API in azure, and put the URL in the template

## REST API Key
Generate a key and add it to the template

## Publish your API
And add the url to the template

## Publish your app
And add the url to the template

## CORS
Allow the portal and your local dev env for both api and app to allow CORS
