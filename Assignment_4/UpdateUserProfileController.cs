using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class UserProfileController : ControllerBase
{
    private readonly IUpdateUserProfileController _UpdateUserProfile;

    public IUserProfileController(IupdateUserProfile UpdateUserProfile)
    {
        _UpdateUserProfile = UpdateUserProfile;
    }

    [HttpPost("Update")]
    public IActionResult UpdateUserProfile(UserProfile model)
    {
        var user = _UpdateUserProfile.UserProfiles.Find(model.UserID);
        if (user == null)
        {
            return NotFound("User not found");
        }

        user.NewPasswordHash = model.NewPasswordHash;
        user.NewEmail = model.NewEmail;
        user.ChangeDODStatus = model.ChangeDODStatus;

        _context.SaveChanges();

        return "User profile updated successfully!";
    }
}
