﻿using ServiceDotNet.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using WorkDiaryRepository.Dbo;
using WorkDiaryRepository.Entities;
using WorkDiaryRepository.Interfaces;

namespace WorkDiaryRepository
{
    public class LogRepository : RepositoryBase, ILogRepository
    {

        public SP_WorkDiaryAppLogs_Result GetLogs(Log entity)
        {

            try
            {

                var result = _db.SP_WorkDiaryAppLogs(
                                            entity.PROVIDER_ID,
                                            entity.JOB_ID,
                                            entity.Start_Time,
                                            entity.End_Time
                                        ).FirstOrDefault();

                return result;

            }
            catch
            {
                throw;
            }
        }

        public CheckProviderByBuyerId_Result CheckProviderByBuyerId(Log entity)
        {
            try
            {

                var result = _db.CheckProviderByBuyerId(
                                            entity.BUYER_ID,
                                            entity.PROVIDER_ID
                                        ).FirstOrDefault();

                return result;

            }
            catch
            {
                throw;
            }
        }

    }
}