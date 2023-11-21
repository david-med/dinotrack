﻿using Dinotrack.Shared.Responses;

namespace Dinotrack.Backend.Helper
{
    public interface IMailHelper
    {
        Response<string> SendMail(string toName, string toEmail, string subject, string body);
    }
}