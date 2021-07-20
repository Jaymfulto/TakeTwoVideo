using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TakeTwoVideo.Models;

namespace TakeTwoVideo.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customers Customer { get; set; }
    }
}