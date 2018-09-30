using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover.Api.Repositories.Interfaces
{
    public interface IMarsRoverRepository
    {
        Task<double> AddMovementValue(double left, double right, double top);
        Task<double> TotalDistanceCovered();
    }
}
