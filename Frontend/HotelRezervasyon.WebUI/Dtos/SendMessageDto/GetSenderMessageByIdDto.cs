﻿using System;

namespace HotelRezervasyon.WebUI.Dtos.SendMessageDto
{
    public class GetSenderMessageByIdDto
    {
        public int SendMessageID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string SenderName { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverMail { get; set; }
        public DateTime Date { get; set; }
    }
}
