# IPv4 Subnetting Tool
A Windows Forms application for calculating and visualizing IPv4 subnetting details, including subnet masks, network IPs, and subnets & host counts.

## Overview
This tool computes subnetting information for a given IPv4 address and CIDR (Classless Inter-Domain Routing) prefix. It calculates:
- Subnet Mask (in dotted-decimal notation)
- IP Class (A, B, or C)
- Network IP
- Subnet IP
- Broadcast IP (of the subnet)
- Number of Subnets
- Number of Hosts per Subnet

Results are displayed in a table for easy viewing and management.

## Features
- **Power of 2 Display**: Toggle to show subnet and host counts as powers of 2 (e.g., 2^8 instead of 256) for educational purposes.
- **Generate Data**: Quickly generate random IP and CIDR values for testing.
- **Generate Entries**: Add multiple random subnet entries to the table at once.
- **Filter Table**: Open a multi-field filter dialog to search and narrow down results (e.g., by IP, CIDR, or class).
- **Clear Table**: Reset the table to start fresh.
- Input validation with warnings for invalid IPs (e.g., loopback or multicast).

## Installation
- **Requirements**: Windows OS with .NET Framework 8.0 or later.
- Download the latest release in the [releases page](https://github.com/Kevin4e/IPv4SubnettingTool/releases).
- Or, clone the repository: `git clone https://github.com/Kevin4e/IPv4SubnettingTool.git`, and build the solution.

## Usage
1. Launch the application.
2. Enter an IPv4 address (e.g., 192.168.1.0) and CIDR (e.g., 24) in the input fields.
3. Click **Compute** to calculate and populate the results table.
4. Use **Generate Data** or **Generate Entries** for random inputs/entries.
5. Click **Filter Table** to apply filters and view subsets of data.
6. Toggle **Display Power of 2** for alternative count formats.

## Interfaces

### Main Form
![Main Interface](Screenshots/Main%20Form.png)

### Filtering Form
![Filtering Interface](Screenshots/Filtering%20Form.png)

## Credits
- **Kevin4e** - Author and developer.
