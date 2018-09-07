This project demonstrates how to make http get and http post requests using C# .Net.

With a GET request we hope to recieve data from the server to the specified resource.  In the GetRequst method we create HttpClient
client object.  This client is responsible for initiating requests to the server.  The GetAsync method sends a GET request that you 
have to input.  The (HttpResponseMessage) response message includes the data and status code that has been returned.  The HttpContent
class is used to give the output from the response.  We then want to get the content from the server, store it in a variable and print
out the contents.

With a POST request we hope to send data to the server.  Using KeyValuePair queries we create a list that takes in two strings
and populate the list with "query1" "stephen" and "query2" "Ian".  When initializing a new instance of the FormEncodedContent class 
be aware that it requires a KeyValuePair structure which in turn must be IEnumerable (helpful link below).  The HttpRespnseMessage 
class has one alteration from the GetRequst method, in this method the client posts asynchronous to the server.  The HttpContentHeaders
class represents the collection of content headers.  Finally the content is printed out to the console.

Links you might find helpful:

https://ptsv2.com/ (Website used for PostRequest)

https://docs.microsoft.com/en-us/dotnet/framework/network-programming/how-to-send-data-using-the-webrequest-class

https://sufiawan.wordpress.com/2015/11/13/c-several-ways-to-perform-http-get-and-post-requests/

http://codesamplez.com/programming/http-request-c-sharp

https://www.c-sharpcorner.com/UploadFile/dacca2/http-request-methods-get-post-put-and-delete/

IEnumerable link info:

https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=netframework-4.7.2






