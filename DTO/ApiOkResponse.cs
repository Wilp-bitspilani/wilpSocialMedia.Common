﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WilpSocialMedia.Common.DTO
{
    public class ApiOkResponse : ApiResponse
    {
        public object Result { get; }
        public int TotalRows { get; }

        public ApiOkResponse(object result, int totalRows = 0)
            : base(200, null)
        {
            Result = result;
            TotalRows = totalRows;
        }
    }
}
