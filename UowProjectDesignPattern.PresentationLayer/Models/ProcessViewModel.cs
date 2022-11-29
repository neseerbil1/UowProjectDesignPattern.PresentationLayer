﻿using System.Data;

namespace UowProjectDesignPattern.PresentationLayer.Models
{
    public class ProcessViewModel
    {
        public int SenderID { get; set; }   
        public int ReceiverID { get; set; }   
        public int Amount { get; set; }   
    }
}
