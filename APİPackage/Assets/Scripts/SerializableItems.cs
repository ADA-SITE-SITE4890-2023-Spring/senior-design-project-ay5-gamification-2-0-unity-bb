using System.Collections.Generic;
using System;

public class AuthContext
{
    public string access_token { get; set; }
    public string token_type { get; set; }
    public int expires_in { get; set; }
    public string refresh_token { get; set; }
    public string scope { get; set; }
    public string user_id { get; set; }
}

[Serializable]
public class Course
{
    public string id;
    public string courseId;
    public string name;
    public bool organization;
    public string ultraStatus;
    public bool readOnly;
    public AvailabilityCourse availability;
    public EnrollmentCourse enrollment;
    public LocaleCourse locale;
    public string externalAccessUrl;
}

[Serializable]
public class MyCourses
{
    public List<Course> results { get; set; }
}

[Serializable]
public class Contents
{
    public List<Content> results;
}

[Serializable]
public class Content
{
    public string id;
    public string title;
    public string body;
    public DateTime created;
    public DateTime modified;
    public int position;
    public bool hasChildren;
    public bool launchInNewWindow;
    public bool reviewable;
    public Availability availability;
    public ContentHandlerResult contentHandler;
    public List<LinkResult> links;
}

[Serializable]
public class File
{
    public string id;
    public string fileName;
    public string mimeType;
}

[Serializable]
public class Files
{
    public List<File> results;
}

[Serializable]
public class Group
{
    public string id;
    public string externalId;
    public string parentId;
    public string name;
    public bool isGroupSet;
    public AvailabilityGroup availability;
    public EnrollmentGroup enrollment;
    public string uuid;
}

[Serializable]
public class GroupList
{
    public List<Group> results;
}

[Serializable]
public class AvailabilityGroup
{
    public string available;
}

[Serializable]
public class EnrollmentGroup
{
    public string type;
    public int limit;
    public SignupSheetGroup signupSheet;
}

[Serializable]
public class Column
{
    public string id;
    public string externalToolId;
    public string name;
    public DateTime created;
}

[Serializable]
public class Grades
{
    public List<Grade> results;
}

[Serializable]
public class Grade
{
    public string userId;
    public string columnId;
    public DisplayGrade displayGrade;
    public bool exempt;
    public int changeIndex;
}

[Serializable]
public class DisplayGrade
{
    public string scaleType;
    public float score;
    public float possible;
    public string title;
}

[Serializable]
public class Announcement
{
    public string id;
    public string title;
    public string body;
    public string creator;
    public bool draft;
    public Availability available;
    public string created;
    public string modified;
    public int position;
}

[Serializable]
public class AnnouncementList
{
    public List<Announcement> results;
}


[Serializable]
public class AvailabilityCourse
{
    public string available;
    public DurationCourse duration;
    public bool AllowGuests;
    public bool AllowObservers;
    public object AdaptiveRelease;
}

[Serializable]
public class DurationCourse
{
    public string type;
    public string start;
    public string end;
}

[Serializable]
public class EnrollmentCourse
{
    public string type;
}

[Serializable]
public class LocaleCourse
{
    public bool force;
}

public class Availability
{
    public string available { get; set; }
    public bool allowGuests { get; set; }
    public bool allowObservers { get; set; }
    public AdaptiveRelease adaptiveRelease { get; set; }
}

public class ContentHandlerResult
{
    public string id { get; set; }
}

public class LinkResult
{
    public string href { get; set; }
    public string rel { get; set; }
    public string title { get; set; }
    public string type { get; set; }
}

public class AdaptiveRelease
{
    public string start { get; set; }
    public string end { get; set; }
}

[Serializable]
public class SignupSheetGroup
{
    public string name;
    public string description;
    public bool showMembers;
}

[Serializable]
public class UserData
{
    public string userName;
    public UserAvatar avatar;
    public UserContact contact;
}

[Serializable]
public class UserAvatar
{
    public string viewUrl;
}

[Serializable]
public class UserContact
{
    public string email;
}
