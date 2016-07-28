using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Mp3_Player
{
    class FileCommands
    {
        public static void readMP3Tag (ref MP3 paramMP3) {
      // Read the 128 byte ID3 tag into a byte array
      FileStream oFileStream;
      oFileStream = new FileStream(paramMP3.fileComplete , FileMode.Open);
      byte[] bBuffer = new byte[128];
      oFileStream.Seek(-128, SeekOrigin.End);
      oFileStream.Read(bBuffer,0, 128);
      oFileStream.Close();
  
      // Convert the Byte Array to a String
      Encoding  instEncoding = new ASCIIEncoding();   // NB: Encoding is an Abstract class
      string id3Tag = instEncoding.GetString(bBuffer);
      
  
      // If there is an attched ID3 v1.x TAG then read it 
      if (id3Tag .Substring(0,3) == "TAG") {
        paramMP3.fileType       = paramMP3.fileFileName.Substring(paramMP3.fileFileName.Length-4,4).Trim();
        paramMP3.id3Title       = id3Tag.Substring(  3, 30).Trim();
        paramMP3.id3Artist      = id3Tag.Substring( 33, 30).Trim();
        paramMP3.id3Album       = id3Tag.Substring( 63, 30).Trim();
        paramMP3.id3Year        = id3Tag.Substring( 93, 4).Trim();
        paramMP3.id3Comment     = id3Tag.Substring( 97,28).Trim();
  
        // Get the track number if TAG conforms to ID3 v1.1
        if (id3Tag[125]==0)
          paramMP3.id3TrackNumber = bBuffer[126];
        else
          paramMP3.id3TrackNumber = 0;
        paramMP3.id3Genre = bBuffer[127];
        paramMP3.hasID3Tag     = true;
        // ********* IF USED IN ANGER: ENSURE to test for non-numeric year
      }
      else 
      {
        // ID3 Tag not found so create an empty TAG in case the user saces later
        paramMP3.id3Title       = "Unknown";
        paramMP3.id3Artist      = "Unknown";
        paramMP3.id3Album       = "";
        paramMP3.id3Year        = "";
        paramMP3.id3Comment     = "";
        paramMP3.id3TrackNumber = 0;
        paramMP3.id3Genre       = 0;
        paramMP3.hasID3Tag      = false;
      }
    }
  
    public static void updateMP3Tag (ref MP3 paramMP3) {
      // Trim any whitespace
      paramMP3.id3Title   = paramMP3.id3Title.Trim();
      paramMP3.id3Artist  = paramMP3.id3Artist.Trim();
      paramMP3.id3Album   = paramMP3.id3Album.Trim();
      paramMP3.id3Year    = paramMP3.id3Year.Trim();
      paramMP3.id3Comment = paramMP3.id3Comment.Trim();
  
      // Ensure all properties are correct size
      if (paramMP3.id3Title.Length > 30)   paramMP3.id3Title    = paramMP3.id3Title.Substring(0,30);
      if (paramMP3.id3Artist.Length > 30)  paramMP3.id3Artist   = paramMP3.id3Artist.Substring(0,30);
      if (paramMP3.id3Album.Length > 30)   paramMP3.id3Album    = paramMP3.id3Album.Substring(0,30);
      if (paramMP3.id3Year.Length > 4)     paramMP3.id3Year     = paramMP3.id3Year.Substring(0,4);
      if (paramMP3.id3Comment.Length > 28) paramMP3.id3Comment  = paramMP3.id3Comment.Substring(0,28);
      
      // Build a new ID3 Tag (128 Bytes)
      byte[] tagByteArray = new byte[128];
      for ( int i = 0; i < tagByteArray.Length; i++ ) tagByteArray[i] = 0; // Initialise array to nulls
  
      // Convert the Byte Array to a String
      Encoding  instEncoding = new ASCIIEncoding();   // NB: Encoding is an Abstract class // ************ To DO: Make a shared instance of ASCIIEncoding so we don't keep creating/destroying it
      // Copy "TAG" to Array
      byte[] workingByteArray = instEncoding.GetBytes("TAG"); 
      Array.Copy(workingByteArray, 0, tagByteArray, 0, workingByteArray.Length);
      // Copy Title to Array
      workingByteArray = instEncoding.GetBytes(paramMP3.id3Title);
      Array.Copy(workingByteArray, 0, tagByteArray, 3, workingByteArray.Length);
      // Copy Artist to Array
      workingByteArray = instEncoding.GetBytes(paramMP3.id3Artist);
      Array.Copy(workingByteArray, 0, tagByteArray, 33, workingByteArray.Length);
      // Copy Album to Array
      workingByteArray = instEncoding.GetBytes(paramMP3.id3Album);
      Array.Copy(workingByteArray, 0, tagByteArray, 63, workingByteArray.Length);
      // Copy Year to Array
      workingByteArray = instEncoding.GetBytes(paramMP3.id3Year);
      Array.Copy(workingByteArray, 0, tagByteArray, 93, workingByteArray.Length);
      // Copy Comment to Array
      workingByteArray = instEncoding.GetBytes(paramMP3.id3Comment);
      Array.Copy(workingByteArray, 0, tagByteArray, 97, workingByteArray.Length);
      // Copy Track and Genre to Array
      tagByteArray[126] = paramMP3.id3TrackNumber;
      tagByteArray[127] = paramMP3.id3Genre;
  
      // SAVE TO DISK: Replace the final 128 Bytes with our new ID3 tag
      FileStream oFileStream = new FileStream(paramMP3.fileComplete , FileMode.Open);
      if (paramMP3.hasID3Tag)
          oFileStream.Seek(-128, SeekOrigin.End);
      else
          oFileStream.Seek(0, SeekOrigin.End);
      oFileStream.Write(tagByteArray,0, 128);
      oFileStream.Close();
      paramMP3.hasID3Tag  = true;
    }
  
  }
  
  struct MP3 {
      public string  filePath;
      public string  fileFileName;
      public string  fileComplete;
      public bool    hasID3Tag;
      public string  id3Title;
      public string  id3Artist;
      public string  id3Album;
      public string  id3Year;
      public string  id3Comment;
      public byte    id3TrackNumber;
      public byte    id3Genre;
      public string fileType;
      
      // Required struct constructor
      public MP3(string path, string name) {
        this.filePath     = path;
        this.fileFileName = name;
        this.fileComplete = path + "\\" + name;
        this.hasID3Tag    = false;
        this.id3Title   = null;
        this.id3Artist    = null;
        this.id3Album   = null;
        this.id3Year    = null;
        this.id3Comment   = null;
        this.id3TrackNumber = 0;
        this.id3Genre   = 0;
        this.fileType = null;
    }
  } 
}
