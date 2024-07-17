using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class favicons
{
    [JsonProperty("rel")]
    public string rel { get; set; }

    [JsonProperty("href")]
    public string href { get; set; }

}

public class headings
{
    [JsonProperty("level")]
    public string level { get; set; }

    [JsonProperty("text")]
    public string text { get; set; }

}

public class imgTags
{
    [JsonProperty("src")]
    public string src { get; set; }

}

public class data
{
    [JsonProperty("requestUrl")]
    public string requestUrl { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("canonical")]
    public string canonical { get; set; }

    [JsonProperty("charset")]
    public string charset { get; set; }

    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("image")]
    public string image { get; set; }

    [JsonProperty("favicons")]
    public favicons[] favicons { get; set; }

    [JsonProperty("author")]
    public string author { get; set; }

    [JsonProperty("description")]
    public string description { get; set; }

    [JsonProperty("keywords")]
    public string keywords { get; set; }

    [JsonProperty("source")]
    public string source { get; set; }

    [JsonProperty("price")]
    public string price { get; set; }

    [JsonProperty("priceCurrency")]
    public string priceCurrency { get; set; }

    [JsonProperty("availability")]
    public string availability { get; set; }

    [JsonProperty("robots")]
    public string robots { get; set; }

    [JsonProperty("jsonld")]
    public object[] jsonld { get; set; }

    [JsonProperty("og:url")]
    public string ogurl { get; set; }

    [JsonProperty("og:locale")]
    public string oglocale { get; set; }

    [JsonProperty("og:locale:alternate")]
    public string oglocalealternate { get; set; }

    [JsonProperty("og:title")]
    public string ogtitle { get; set; }

    [JsonProperty("og:type")]
    public string ogtype { get; set; }

    [JsonProperty("og:description")]
    public string ogdescription { get; set; }

    [JsonProperty("og:determiner")]
    public string ogdeterminer { get; set; }

    [JsonProperty("og:site_name")]
    public string ogsitename { get; set; }

    [JsonProperty("og:image")]
    public string ogimage { get; set; }

    [JsonProperty("og:image:secure_url")]
    public string ogimagesecureurl { get; set; }

    [JsonProperty("og:image:type")]
    public string ogimagetype { get; set; }

    [JsonProperty("og:image:width")]
    public string ogimagewidth { get; set; }

    [JsonProperty("og:image:height")]
    public string ogimageheight { get; set; }

    [JsonProperty("twitter:title")]
    public string twittertitle { get; set; }

    [JsonProperty("twitter:description")]
    public string twitterdescription { get; set; }

    [JsonProperty("twitter:image")]
    public string twitterimage { get; set; }

    [JsonProperty("twitter:image:alt")]
    public string twitterimagealt { get; set; }

    [JsonProperty("twitter:card")]
    public string twittercard { get; set; }

    [JsonProperty("twitter:site")]
    public string twittersite { get; set; }

    [JsonProperty("twitter:site:id")]
    public string twittersiteid { get; set; }

    [JsonProperty("twitter:url")]
    public string twitterurl { get; set; }

    [JsonProperty("twitter:account_id")]
    public string twitteraccountid { get; set; }

    [JsonProperty("twitter:creator")]
    public string twittercreator { get; set; }

    [JsonProperty("twitter:creator:id")]
    public string twittercreatorid { get; set; }

    [JsonProperty("twitter:player")]
    public string twitterplayer { get; set; }

    [JsonProperty("twitter:player:width")]
    public string twitterplayerwidth { get; set; }

    [JsonProperty("twitter:player:height")]
    public string twitterplayerheight { get; set; }

    [JsonProperty("twitter:player:stream")]
    public string twitterplayerstream { get; set; }

    [JsonProperty("twitter:app:name:iphone")]
    public string twitterappnameiphone { get; set; }

    [JsonProperty("twitter:app:id:iphone")]
    public string twitterappidiphone { get; set; }

    [JsonProperty("twitter:app:url:iphone")]
    public string twitterappurliphone { get; set; }

    [JsonProperty("twitter:app:name:ipad")]
    public string twitterappnameipad { get; set; }

    [JsonProperty("twitter:app:id:ipad")]
    public string twitterappidipad { get; set; }

    [JsonProperty("twitter:app:url:ipad")]
    public string twitterappurlipad { get; set; }

    [JsonProperty("twitter:app:name:googleplay")]
    public string twitterappnamegoogleplay { get; set; }

    [JsonProperty("twitter:app:id:googleplay")]
    public string twitterappidgoogleplay { get; set; }

    [JsonProperty("twitter:app:url:googleplay")]
    public string twitterappurlgoogleplay { get; set; }

    [JsonProperty("headings")]
    public headings[] headings { get; set; }

    [JsonProperty("imgTags")]
    public imgTags[] imgTags { get; set; }

    [JsonProperty("responseBody")]
    public string responseBody { get; set; }

    [JsonProperty("fb:app_id")]
    public string fbappid { get; set; }

    [JsonProperty("msapplication-TileColor")]
    public string msapplicationTileColor { get; set; }

    [JsonProperty("msapplication-TileImage")]
    public string msapplicationTileImage { get; set; }

    [JsonProperty("p:domain_verify")]
    public string pdomainverify { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
