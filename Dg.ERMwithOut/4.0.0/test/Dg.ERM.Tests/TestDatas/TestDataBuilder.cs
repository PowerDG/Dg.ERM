using Dg.ERM.EntityFrameworkCore;

namespace Dg.ERM.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly ERMDbContext _context;

        public TestDataBuilder(ERMDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}