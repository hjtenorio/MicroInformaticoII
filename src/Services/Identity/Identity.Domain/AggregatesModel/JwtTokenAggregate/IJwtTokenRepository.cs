using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Domain.AggregatesModel.JwtTokenAggregate
{
    public interface IJwtTokenRepository
    {
        string CreateJwtToken(string secret, string name, string login);
    }
}
