using System;

namespace Play.Catalog.Contacts
{
    public record CatalogItemCreated(Guid ItemId, string Name, string Description);

    public record CatalogItemUpdated(Guid ItemId, string Name, string Description);

    public record CatalogItemDeleted(Guid ItemId);
}
