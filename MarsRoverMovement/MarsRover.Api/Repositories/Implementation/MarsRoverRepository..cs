using MarsRover.Api.Models;
using MarsRover.Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover.Api.Repositories.Implementation
{
    public class MarsRoverRepository : IMarsRoverRepository
    {
        private MarsRoverContext _context;

        public MarsRoverRepository(MarsRoverContext context)
        {
            _context = context;
        }

        public async Task<double> AddMovementValue(double left, double right, double top)
        {
            var marsMovermentEntity = new MarsRoverMovement { Left = left, Right = right, Top = top };
            _context.Entry<MarsRoverMovement>(marsMovermentEntity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            return await _context.SaveChangesAsync();
        }

        public async Task<double> TotalDistanceCovered()
        {
            throw new NotImplementedException();
        }
    }
}
