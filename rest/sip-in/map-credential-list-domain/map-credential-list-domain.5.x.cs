// Download the twilio-csharp library from
// https://www.twilio.com/docs/libraries/csharp#installation
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account.Sip.Domain;

class Example
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Auth Token at twilio.com/user/account
        string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var credentialListMapping = CredentialListMappingResource.Create(
            "SD32a3c49700934481addd5ce1659f04d2",
            "CL32a3c49700934481addd5ce1659f04d2");

        Console.WriteLine(credentialListMapping.Sid);
    }
}
