[System.Serializable]


    public class Course
    {
      public string id;
      public string courseId;
      public string name;
      public string title;
      public bool organization;
      public string ultraStatus;
      public bool readOnly;
      public Availability availability;
      public Enrollment enrollment;
      public Locale locale;
      public string externalAccessUrl;
    }


public class Availability
{
    public string available;
    public Duration duration;
}


public class Duration
{
    public string type;
}

public class Enrollment
{
    public string type;
}

public class Locale
{
    public bool force;
}
