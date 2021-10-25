using MagicGrpc.EntityFrameworkCore;

namespace MagicGrpc.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MagicGrpcDbContext _context;

        public TestDataBuilder(MagicGrpcDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}