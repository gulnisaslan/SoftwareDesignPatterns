﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
           CustomerManager customerManager=new CustomerManager();
          customerManager.MessageSenderBase=new EmailSender();
           customerManager.UpdateCustomer();
        }
    }
    abstract  class MessageSenderBase
    {
        public void Save(){
           Console.WriteLine("Message Saved");
        }

        public abstract void Send(Body body);
            
    }

     public class Body
     {
         public string Title { get; set; }
         public string Text { get; set; }
     }

     class SmsSender : MessageSenderBase
     {
          public override void Send(Body body)
          {
             Console.WriteLine("{0} was sent via SmsSender",body.Title);
          }
     }
     class EmailSender : MessageSenderBase
     {
          public override void Send(Body body)
          {
              Console.WriteLine("{0} was sent via SmsSender",body.Title);
          }
     }
     class CustomerManager
     {
         public MessageSenderBase  MessageSenderBase { get; set; }
         public void UpdateCustomer(){
             MessageSenderBase.Send(new Body{Title="About the Course"});
             Console.WriteLine("Customer Updated");
         }
     }
}
