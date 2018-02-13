// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.KeyVault.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.KeyVault.Fluent.Key.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;

    /// <summary>
    /// Entry point for Key Vault keys API.
    /// </summary>
    public interface IKeys  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IBeta,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsCreating<Key.Definition.IBlank>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsDeletingById,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsGettingById<Microsoft.Azure.Management.KeyVault.Fluent.IKey>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListing<Microsoft.Azure.Management.KeyVault.Fluent.IKey>
    {
        /// <summary>
        /// Restores a backup key into a Key Vault key.
        /// </summary>
        /// <param name="backup">The backup key.</param>
        /// <return>The key restored from the backup.</return>
        Microsoft.Azure.Management.KeyVault.Fluent.IKey Restore(params byte[] backup);

        /// <summary>
        /// Restores a backup key into a Key Vault key.
        /// </summary>
        /// <param name="backup">The backup key.</param>
        /// <return>The key restored from the backup.</return>
        Task<Microsoft.Azure.Management.KeyVault.Fluent.IKey> RestoreAsync(byte[] backup, CancellationToken cancellationToken = default(CancellationToken));
    }
}