﻿using System;

namespace TechSupport.Model
{
    /// <summary>
    /// This class models a Tech Support Incident Report.
    /// </summary>
    public class Incident
    {
        public string Title { get; }
        public string Description { get; }
        public int CustomerID { get; }

        /// <summary>
        /// 3-param constructor
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="customerid"></param>
        public Incident(string title, string description, int customerid)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Incident title cannot be null or empty", "title");
            }
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Incident description cannot be null or empty", "description");
            }
            if (customerid < 1)
            {
                throw new ArgumentException("Invalid CustomerID", "customerid");
            }

            this.Title = title;
            this.Description = description;
            this.CustomerID = customerid;
        }
    }
}
