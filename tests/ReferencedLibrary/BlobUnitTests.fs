module BlobTests

open FSharp.Azure.StorageTypeProvider
open FSharp.Azure.StorageTypeProvider.Blob
open Microsoft.Azure.Storage.Blob

type Local = BlobTypeProvider<"UseDevelopmentStorage=true", "">
type BlobSchema = BlobTypeProvider<blobSchema = "BlobSchema.json">
