using Microsoft.AspNetCore.Authorization;

namespace SecurityApp.Authorization
{
    public class OnlyAdminAuthorization : AuthorizationHandler<OnlyAdminAuthorization>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OnlyAdminAuthorization requirement)
        {
            if (context.User.IsInRole("Administrator"))
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }
            return Task.CompletedTask;
        }
    }
}
