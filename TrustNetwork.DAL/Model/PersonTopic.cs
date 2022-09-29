﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrustNetwork.DAL.Model;

public class PersonTopic
{
    public int PersonId { get; set; }
    public Person Person { get; set; } = null!;
    public int TopicId { get; set; }
    public Topic Topic { get; set; } = null;
}
