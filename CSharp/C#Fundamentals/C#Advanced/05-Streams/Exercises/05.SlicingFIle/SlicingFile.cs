﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Ex5SlicingFIle
{
    class SlicingFile
    {
        static void Main(string[] args)
        {

            string inputPath = "../../../../InputFiles";
            string outputPath = "../../../../Outputfiles/05-SlicedFiles/";
            string fileName = "sliceMe.mp4";
            inputPath = Path.Combine(inputPath, fileName);
            outputPath = Path.Combine(outputPath);
            List<string> parts = Slice(inputPath, outputPath, 5);
            Assemble(parts, outputPath);
        }

        private static List<string> Slice(string sourceFile, string destinationDirectory, int parts)
        {
            List<string> files = new List<string>();

            using (var readStream = new FileStream(sourceFile, FileMode.Open))
            {
                long partLength = (long)Math.Ceiling(1.0 * readStream.Length / parts);
                for (int currPart = 0; currPart < parts; currPart++)
                {
                    string fileName = destinationDirectory + "Part_" + currPart +
                                      sourceFile.Substring(sourceFile.LastIndexOf('.'));

                    files.Add(fileName);

                    long totalCopied = 0;

                    using (var writeStream = new FileStream(fileName, FileMode.Create))
                    {
                        while (totalCopied < partLength)
                        {
                            byte[] buffer = new byte[4096];
                            int byteCount = readStream.Read(buffer, 0, 4096);
                            if (byteCount == 0)
                            {
                                break;
                            }

                            writeStream.Write(buffer, 0, byteCount);
                            totalCopied += 4096;
                        }
                    }
                }
            }

            return files;
        }

        private static void Assemble(List<string> files, string destinationDirectory)
        {
            using (var writeStream = new FileStream(destinationDirectory + "assembled" + files[0].Substring(files[0].LastIndexOf('.')), FileMode.Create))
            {
                foreach (var file in files)
                {
                    using (var readStream = new FileStream(file, FileMode.Open))
                    {
                        while (true)
                        {
                            byte[] buffer = new byte[4096];
                            int byteCount = readStream.Read(buffer, 0, buffer.Length);
                            if (byteCount == 0)
                            {
                                break;
                            }

                            writeStream.Write(buffer, 0, byteCount);
                        }
                    }
                }
            }
        }
    }
}
