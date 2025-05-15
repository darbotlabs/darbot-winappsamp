# Offline Dependencies Setup

This document provides instructions for setting up offline dependencies for the project. Follow the steps below to ensure that all necessary dependencies are packaged and available for offline installation.

## Steps to Package Dependencies

1. **Download Dependencies**:
   - Download all necessary dependencies and save them in the `offline-dependencies` folder within the `darbot` directory.

2. **Update Project Files**:
   - Update the project files to reference the local copies of the dependencies instead of downloading them from external sources.
   - Modify the `packages.config` files to point to the local copies of the dependencies.

3. **Update Scripts and Build Commands**:
   - Ensure that any scripts or build commands are updated to use the local copies of the dependencies.
   - Modify the `build.cmd` script to reference the `offline-dependencies` directory.

4. **Document the Process**:
   - Document the process for setting up the offline dependencies in this `README.md` file.
   - Include instructions on how to use the local copies of the dependencies and any necessary steps to update the project files.

## Using Local Copies of Dependencies

To use the local copies of the dependencies, follow these steps:

1. **Modify `packages.config` Files**:
   - Open the `packages.config` files in the project.
   - Update the paths to point to the local copies of the dependencies in the `offline-dependencies` folder.

2. **Update `build.cmd` Script**:
   - Open the `build.cmd` script.
   - Modify the script to reference the `offline-dependencies` directory for the dependencies.

3. **Build the Project**:
   - Run the `build.cmd` script to build the project using the local copies of the dependencies.

By following these steps, you can ensure that all necessary dependencies are packaged and available for offline installation, making it easier to set up and use the project without requiring an internet connection.
