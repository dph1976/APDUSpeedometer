# APDUSpeedometer
A simple Windows app to send APDU to smart cards and measure the response time of the card.

## Quick Overview
This app can do following things:
- Send APDU command to get ATR of the card
- Send APDU commands to read the ICCID of a SIM card
- Send APDU commands to read the IMSI 2G (in DF_GSM) of a SIM card
- Send a single APDU command to the card and measure the response time
- Send a batch of APDU commands to the card and measure the response time for each APDU in the batch.

This app is expecially useful when a speed of response is concerned. For example in 5G networks, SUCI calculation of 5G SA SIMcard can afftect the network qualiity if it takes too long to response (e.g. not in miliseconds). The connection or the calls can be dropped at the edge of 5G network because handset can swing from 5G to 4G back to 5G network frequently and thus need SUCI response fast enough to maintain the connection.

## Installing
If you are running a Windows base operating system, download the release at https://github.com/dph1976/APDUSpeedometer/releases/, extract the zip file and launch the executable file inside. The software should work straight away.

In case that the software can't be launch, check that lastest .Net Framework is installed on your PC. (.NET desktop 8.0)

This software only support Windows operating system, doesn't support Android, macOS or Linux.

## Version
-(Release 1) Version 1.0.0 : Initial Release  

## Built With
This application is built using VB.Net on Visual Studio 2022 Community Edition. This software use PC/SC wrapper class for .NET developed by Daniel Mueller, for more information about this library see: https://github.com/danm-de/pcsc-sharp/

This application also take a reference from APDUSender here: https://github.com/tithanayut/APDUSender

The default framework version is set to .Net Framework 4.5, but able to functioning correctly when newer version of .Net Framework is selected.

The program is tested with OMNI-Key Card 3x21 (contact reader).
According to the PC/SC Library, this software support all of PC/SC compatible reader.

## Authors
Code/project developed by Huyen Doan (https://github.com/dph1976)
PC/SC wrapper classes for .NET developed by Daniel Mueller, see https://github.com/danm-de/pcsc-sharp/.

## License
This software and its sources license under BSD 2-Clause License. Feel free to use, modify, redistribute under the BSD 2-Clause License. For more information see: LICENSE file.

Note: This software use PC/SC wrapper classes for .NET developed by Daniel Mueller, for license see: https://github.com/danm-de/pcsc-sharp/blob/master/COPYING.

Keyword: APDU Speedometer, measure response time of APDU, Send and Receive APDU, APDU Command Sender, Smart Card APDU Tool

