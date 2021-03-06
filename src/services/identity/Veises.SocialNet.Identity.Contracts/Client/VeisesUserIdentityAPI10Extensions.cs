// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veises.SocialNet.Identity.Contracts.Client
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VeisesUserIdentityAPI10.
    /// </summary>
    public static partial class VeisesUserIdentityAPI10Extensions
    {
            /// <summary>
            /// Get specified user identity
            /// </summary>
            /// <remarks>
            /// Get user by a unique identifier.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Identity unique identificator
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            public static UserIdentity ApiV1IdentityByIdGet(this IVeisesUserIdentityAPI10 operations, string id, string apiVersion = default(string))
            {
                return operations.ApiV1IdentityByIdGetAsync(id, apiVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get specified user identity
            /// </summary>
            /// <remarks>
            /// Get user by a unique identifier.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Identity unique identificator
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserIdentity> ApiV1IdentityByIdGetAsync(this IVeisesUserIdentityAPI10 operations, string id, string apiVersion = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiV1IdentityByIdGetWithHttpMessagesAsync(id, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Upate user identity
            /// </summary>
            /// <remarks>
            /// Update exists user identity
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Identity unique identificator
            /// </param>
            /// <param name='updateUserIdentity'>
            /// User identity information
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            public static UserIdentity ApiV1IdentityByIdPut(this IVeisesUserIdentityAPI10 operations, string id, UpdateUserIdentity updateUserIdentity = default(UpdateUserIdentity), string apiVersion = default(string))
            {
                return operations.ApiV1IdentityByIdPutAsync(id, updateUserIdentity, apiVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Upate user identity
            /// </summary>
            /// <remarks>
            /// Update exists user identity
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Identity unique identificator
            /// </param>
            /// <param name='updateUserIdentity'>
            /// User identity information
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserIdentity> ApiV1IdentityByIdPutAsync(this IVeisesUserIdentityAPI10 operations, string id, UpdateUserIdentity updateUserIdentity = default(UpdateUserIdentity), string apiVersion = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiV1IdentityByIdPutWithHttpMessagesAsync(id, updateUserIdentity, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new user identity
            /// </summary>
            /// <remarks>
            /// Create new user identity
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='createIdentityModel'>
            /// Create user identity information
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            public static UserIdentity ApiV1IdentityPost(this IVeisesUserIdentityAPI10 operations, CreateUserIdentity createIdentityModel = default(CreateUserIdentity), string apiVersion = default(string))
            {
                return operations.ApiV1IdentityPostAsync(createIdentityModel, apiVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create new user identity
            /// </summary>
            /// <remarks>
            /// Create new user identity
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='createIdentityModel'>
            /// Create user identity information
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserIdentity> ApiV1IdentityPostAsync(this IVeisesUserIdentityAPI10 operations, CreateUserIdentity createIdentityModel = default(CreateUserIdentity), string apiVersion = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiV1IdentityPostWithHttpMessagesAsync(createIdentityModel, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
