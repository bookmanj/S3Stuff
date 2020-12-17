using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadToS3Demo
{
  class Program
  {
    static async Task Main(string[] args)
    {
      // preparing our file and directory names
      string fileToBackup = @"C:\S3Temp\pluralsights3bucketjay\LICENSE"; // test file
      string myBucketName = "pluralsights3bucketjay"; //your s3 bucket name goes here
      string s3DirectoryName = "justdemodirectory";
      string s3FileName = @"LICENSE";

      AmazonUploader myUploader = new AmazonUploader();
      await myUploader.sendMyFileToS3(fileToBackup, myBucketName, s3DirectoryName, s3FileName);
    }
  }
}