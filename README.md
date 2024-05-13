# DevOps Assessment #

Hello and thank you for your interest in applying to A&A Engineering’s DevOp role. We have devised a an assessment expected to take 3 - 4 hours.
We have created a minimal C# project to test your ability to set up a Continuous Integration / Continuous Deployment pipeline.

Using Jenkins, or another automation software, upon triggering a public link, set up a pipeline that compiles the master branch of this repository (you will need to use MSBuild for this). Once compiled you should then upload the resulting exe to a specific FTP address. The address and its access credentials will be given to you in the assessment email; it is different for each candidate.

Please set up your automation software inside a container(docker or kubernetes) or virtual machine so it can be shared with us. For the test, the container should be deployed or otherwise set up on a free/cheap vps such as AWS, Google Cloud, Oracle Cloud Infrastructure.