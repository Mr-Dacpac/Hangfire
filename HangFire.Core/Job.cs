﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace HangFire
{
    public class Job
    {
        public static Job Deserialize(string serializedJob)
        {
            return JsonHelper.Deserialize<Job>(serializedJob);
        }

        public Job(Type workerType, object args)
        {
            Jid = Guid.NewGuid().ToString();
            WorkerType = workerType;
            Args = new Dictionary<string, string>();
            EnqueuedAt = DateTime.UtcNow;

            AddValues(Args, args);
        }

        public string Jid { get; internal set; }
        public Type WorkerType { get; internal set; }
        public IDictionary<string, string> Args { get; internal set; }
        public DateTime EnqueuedAt { get; internal set; }
        public DateTime? SucceededAt { get; internal set; }
        public DateTime? FailedAt { get; internal set; }

        public TimeSpan? Latency
        {
            get
            {
                if (SucceededAt.HasValue)
                {
                    return SucceededAt.Value.Subtract(EnqueuedAt);
                }
                if (FailedAt.HasValue)
                {
                    return FailedAt.Value.Subtract(EnqueuedAt);
                }

                return null;
            }
        }

        [IgnoreDataMember]
        public bool Canceled { get; private set; }

        public void Cancel()
        {
            Canceled = true;
        }

        public string Serialize()
        {
            return JsonHelper.Serialize(this);
        }

        public string SerializeArgs()
        {
            return JsonHelper.Serialize(Args);
        }

        private static void AddValues(IDictionary<string, string> dictionary, object values)
        {
            if (values != null)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(values))
                {
                    var obj2 = descriptor.GetValue(values);
                    dictionary.Add(descriptor.Name, obj2 != null ? obj2.ToString() : null);
                }
            }
        }
    }
}