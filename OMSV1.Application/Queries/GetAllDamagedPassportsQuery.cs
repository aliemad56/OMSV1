﻿using MediatR;
using OMSV1.Domain.Entities.DamagedPassport;
using System.Collections.Generic;

namespace OMSV1.Application.Queries
{
    public class GetAllDamagedPassportsQuery : IRequest<IReadOnlyList<DamagedPassport>>
    {
    }
}
