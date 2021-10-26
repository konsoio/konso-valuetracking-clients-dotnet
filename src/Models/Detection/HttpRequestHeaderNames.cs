namespace InDevLabs.Infra.Activity.Models.Detection
{
    /// <summary>
    /// Mostly Taken from https://docs.microsoft.com/en-us/dotnet/api/system.net.httprequestheader and wikipedia
    /// </summary>
    public static class HttpRequestHeaderNames
    {
        /// <summary>
        /// The Accept header, which specifies the MIME types that are acceptable for the response.
        /// </summary>
        public static string Accept => "Accept";

        /// <summary>
        /// The Accept-Charset header, which specifies the character sets that are acceptable for the response. 
        /// </summary>
        public static string AcceptCharset => "Accept-Charset";

        /// <summary>
        /// The Accept-Encoding header, which specifies the content encodings that are acceptable for the response. 
        /// </summary>
        public static string AcceptEncoding => "Accept-Encoding";

        /// <summary>
        /// The Accept-Langauge header, which specifies that natural languages that are preferred for the response.
        /// </summary>
        public static string AcceptLanguage => "Accept-Langauge";

        /// <summary>
        /// The Allow header, which specifies the set of HTTP methods supported.
        /// </summary>
        public static string Allow => "Allow";

        /// <summary>
        /// The Authorization header, which specifies the credentials that the client presents in order to authenticate itself to the server. 
        /// </summary>
        public static string Authorization => "Authorization";

        /// <summary>
        /// The Cache-Control header, which specifies directives that must be obeyed by all cache control mechanisms along the request/response chain.
        /// </summary>
        public static string CacheControl => "Cache-Control";

        /// <summary>
        /// The Connection header, which specifies options that are desired for a particular connection. 
        /// </summary>
        public static string Connection => "Connection";

        /// <summary>
        /// The Content-Encoding header, which specifies the encodings that have been applied to the accompanying body data. 
        /// </summary>
        public static string ContentEncoding => "Content-Encoding";

        /// <summary>
        /// The Content-Langauge header, which specifies the natural language(s) of the accompanying body data. 
        /// </summary>
        public static string ContentLanguage => "Content-Langauge";

        /// <summary>
        /// The Content-Length header, which specifies the length, in bytes, of the accompanying body data.
        /// </summary>
        public static string ContentLength => "Content-Length";

        /// <summary>
        /// The Content-Location header, which specifies a URI from which the accompanying body may be obtained.
        /// </summary>
        public static string ContentLocation => "Content-Location";

        /// <summary>
        /// The Content-MD5 header, which specifies the MD5 digest of the accompanying body data, for the purpose of providing an end-to-end message integrity check.
        /// </summary>
        public static string ContentMd5 => "Content-MD5";

        /// <summary>
        /// The Content-Range header, which specifies where in the full body the accompanying partial body data should be applied.
        /// </summary>
        public static string ContentRange => "Content-Range";

        /// <summary>
        /// The Content-Type header, which specifies the MIME type of the accompanying body data.
        /// </summary>
        public static string ContentType => "Content-Type";

        /// <summary>
        /// The Cookie header, which specifies cookie data presented to the server.
        /// </summary>
        public static string Cookie => "Cookie";

        /// <summary>
        /// The Date header, which specifies the date and time at which the request originated.
        /// </summary>
        public static string Date => "Date";

        /// <summary>
        /// The Expect header, which specifies particular server behaviors that are required by the client. 
        /// </summary>
        public static string Expect => "Expect";

        /// <summary>
        /// The Expires header, which specifies the date and time after which the accompanying body data should be considered stale. 
        /// </summary>
        public static string Expires => "Expires";

        /// <summary>
        /// The From header, which specifies an Internet Email address for the human user who controls the requesting user agent. 
        /// </summary>
        public static string From => "From";

        /// <summary>
        /// The Host header, which specifies the host name and port number of the resource being requested. 
        /// </summary>
        public static string Host => "Host";

        /// <summary>
        /// The If-Match header, which specifies that the requested operation should be performed only if the client's cached copy of the indicated resource is current. 
        /// </summary>
        public static string IfMatch => "If-Match";

        /// <summary>
        /// The If-Modified-Since header, which specifies that the requested operation should be performed only if the requested resource has been modified since the indicated data and time.
        /// </summary>
        public static string IfModifiedSince => "If-Modified-Since";

        /// <summary>
        /// The If-None-Match header, which specifies that the requested operation should be performed only if none of client's cached copies of the indicated resources are current. 
        /// </summary>
        public static string IfNoneMatch => "If-None-Match";

        /// <summary>
        /// The If-Range header, which specifies that only the specified range of the requested resource should be sent, if the client's cached copy is current.
        /// </summary>
        public static string IfRange => "If-Range";

        /// <summary>
        /// The If-Unmodified-Since header, which specifies that the requested operation should be performed only if the requested resource has not been modified since the indicated date and time. 
        /// </summary>
        public static string IfUnmodifiedSince => "If-Unmodified-Since";

        /// <summary>
        /// The Keep-Alive header, which specifies a parameter used into order to maintain a persistent connection.
        /// </summary>
        public static string KeepAlive => "Keep-Alive";

        /// <summary>
        /// The Last-Modified header, which specifies the date and time at which the accompanying body data was last modified.
        /// </summary>
        public static string LastModified => "Last-Modified";

        /// <summary>
        /// The Max-Forwards header, which specifies an integer indicating the remaining number of times that this request may be forwarded. 
        /// </summary>
        public static string MaxForwards => "Max-Forwards";

        /// <summary>
        /// The Pragma header, which specifies implementation-specific directives that might apply to any agent along the request/response chain.
        /// </summary>
        public static string Pragma => "Pragma";

        /// <summary>
        /// The Proxy-Authorization header, which specifies the credentials that the client presents in order to authenticate itself to a proxy.
        /// </summary>
        public static string ProxyAuthorization => "Proxy-Authorization";

        /// <summary>
        /// The Range header, which specifies the sub-range(s) of the response that the client requests be returned in lieu of the entire response.
        /// </summary>
        public static string Range => "Range";

        /// <summary>
        /// The Referer header, which specifies the URI of the resource from which the request URI was obtained.
        /// </summary>
        public static string Referer => "Referer";

        /// <summary>
        /// The TE header, which specifies the transfer encodings that are acceptable for the response.
        /// </summary>
        public static string Te => "TE";

        /// <summary>
        /// The Trailer header, which specifies the header fields present in the trailer of a message encoded with chunked transfer-coding.
        /// </summary>
        public static string Trailer => "Trailer";

        /// <summary>
        /// The Transfer-Encoding header, which specifies what (if any) type of transformation that has been applied to the message body.
        /// </summary>
        public static string TransferEncoding => "Transfer-Encoding";

        /// <summary>
        /// The Translate header, a Microsoft extension to the HTTP specification used in conjunction with WebDAV functionality. 
        /// </summary>
        public static string Translate => "Translate";

        /// <summary>
        /// The Upgrade header, which specifies additional communications protocols that the client supports.
        /// </summary>
        public static string Upgrade => "Upgrade";

        /// <summary>
        /// The User-Agent header, which specifies information about the client agent.
        /// </summary>
        public static string UserAgent => "User-Agent";

        /// <summary>
        /// The X-Forwarded-For (XFF) HTTP header field is a common method for identifying the originating IP address of a client connecting to a web server through an HTTP proxy or load balancer. The XFF HTTP request header was introduced by the Squid caching proxy server's developers.
        /// </summary>
        public static string XForwardedFor => "X-Forwarded-For";

        /// <summary>
        /// The X-Real-IP used by Nginx
        /// </summary>
        public static string XRealIP => "X-Real-IP";

        /// <summary>
        /// The X-Original-For
        /// </summary>
        public static string XOriginalFor => "X-Original-For";

        /// <summary>
        /// The X-Forwarded-Proto (XFP) header is a de-facto standard header for identifying the protocol (HTTP or HTTPS) that a client used to connect to your proxy or load balancer. 
        /// </summary>
        public static string XOriginalProto => "X-Original-Proto";
        /// <summary>
        /// The Via header, which specifies intermediate protocols to be used by gateway and proxy agents.
        /// </summary>
        public static string Via => "Via";

        /// <summary>
        /// The Warning header, which specifies additional information about that status or transformation of a message that might not be reflected in the message.
        /// </summary>
        public static string Warning => "Warning";
    }
}
