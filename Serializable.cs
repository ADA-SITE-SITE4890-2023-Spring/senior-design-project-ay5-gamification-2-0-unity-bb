[System.Serializable]

public class Course
{
	public string id;
	public string courseId;
	public string name;
	public bool organization;
	public string ultraStatus;
	public bool readOnly;
	public Availability1 availability;
	public Enrollment1 enrollment;
	public Locale1 locale;
	public string externalAccessUrl;
}

[System.Serializable]
public class Availability1
{
	public string available;
	public Duration1 duration;
}

[System.Serializable]
public class Duration1
{
	public string type;
}

[System.Serializable]
public class Locale1
{
	public bool force;
}

[System.Serializable]
public class Enrollment1
{
	public string type;
}