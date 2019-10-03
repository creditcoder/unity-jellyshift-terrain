namespace System.Net
{
	/// <summary>The HTTP headers that can be specified in a server response.</summary>
	public enum HttpResponseHeader
	{
		/// <summary>The Cache-Control header, which specifies caching directives that must be obeyed by all caching mechanisms along the request/response chain.</summary>
		CacheControl,
		/// <summary>The Connection header, which specifies options that are desired for a particular connection.</summary>
		Connection,
		/// <summary>The Date header, which specifies the date and time at which the response originated.</summary>
		Date,
		/// <summary>The Keep-Alive header, which specifies a parameter to be used to maintain a persistent connection.</summary>
		KeepAlive,
		/// <summary>The Pragma header, which specifies implementation-specific directives that might apply to any agent along the request/response chain.</summary>
		Pragma,
		/// <summary>The Trailer header, which specifies that the indicated header fields are present in the trailer of a message that is encoded with chunked transfer-coding.</summary>
		Trailer,
		/// <summary>The Transfer-Encoding header, which specifies what (if any) type of transformation has been applied to the message body.</summary>
		TransferEncoding,
		/// <summary>The Upgrade header, which specifies additional communications protocols that the client supports.</summary>
		Upgrade,
		/// <summary>The Via header, which specifies intermediate protocols to be used by gateway and proxy agents.</summary>
		Via,
		/// <summary>The Warning header, which specifies additional information about that status or transformation of a message that might not be reflected in the message.</summary>
		Warning,
		/// <summary>The Allow header, which specifies the set of HTTP methods that are supported.</summary>
		Allow,
		/// <summary>The Content-Length header, which specifies the length, in bytes, of the accompanying body data.</summary>
		ContentLength,
		/// <summary>The Content-Type header, which specifies the MIME type of the accompanying body data.</summary>
		ContentType,
		/// <summary>The Content-Encoding header, which specifies the encodings that have been applied to the accompanying body data.</summary>
		ContentEncoding,
		/// <summary>The Content-Langauge header, which specifies the natural language or languages of the accompanying body data.</summary>
		ContentLanguage,
		/// <summary>The Content-Location header, which specifies a URI from which the accompanying body can be obtained.</summary>
		ContentLocation,
		/// <summary>The Content-MD5 header, which specifies the MD5 digest of the accompanying body data, for the purpose of providing an end-to-end message integrity check.</summary>
		ContentMd5,
		/// <summary>The Range header, which specifies the subrange or subranges of the response that the client requests be returned in lieu of the entire response.</summary>
		ContentRange,
		/// <summary>The Expires header, which specifies the date and time after which the accompanying body data should be considered stale.</summary>
		Expires,
		/// <summary>The Last-Modified header, which specifies the date and time at which the accompanying body data was last modified.</summary>
		LastModified,
		/// <summary>The Accept-Ranges header, which specifies the range that is accepted by the server.</summary>
		AcceptRanges,
		/// <summary>The Age header, which specifies the time, in seconds, since the response was generated by the originating server.</summary>
		Age,
		/// <summary>The Etag header, which specifies the current value for the requested variant. </summary>
		ETag,
		/// <summary>The Location header, which specifies a URI to which the client is redirected to obtain the requested resource.</summary>
		Location,
		/// <summary>The Proxy-Authenticate header, which specifies that the client must authenticate itself to a proxy.</summary>
		ProxyAuthenticate,
		/// <summary>The Retry-After header, which specifies a time (in seconds), or a date and time, after which the client can retry its request.</summary>
		RetryAfter,
		/// <summary>The Server header, which specifies information about the originating server agent.</summary>
		Server,
		/// <summary>The Set-Cookie header, which specifies cookie data that is presented to the client.</summary>
		SetCookie,
		/// <summary>The Vary header, which specifies the request headers that are used to determine whether a cached response is fresh.</summary>
		Vary,
		/// <summary>The WWW-Authenticate header, which specifies that the client must authenticate itself to the server.</summary>
		WwwAuthenticate
	}
}
