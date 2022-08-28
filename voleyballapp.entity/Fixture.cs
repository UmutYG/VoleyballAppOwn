using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voleyballapp.entity
{
    public class Fixture
    {
        public int Id { get; set; }
        public int HostId { get; set; }
        public int GuestId { get; set; }
    }
}