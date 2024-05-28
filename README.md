# APDUSpeedometer
A simple Windows app to send APDU to smart cards and measure the response time of the card
This app can do following things:
- Send APDU command to get ATR of the card
- Send APDU commands to read the ICCID of a SIM card
- Send APDU commands to read the IMSI 2G (in DF_GSM) of a SIM card
- Send a single APDU command to the card and measure the response time
- Send a batch of APDU commands to the card and measure the response time for each APDU in the batch.

This app is expecially useful when a speed of response is concerned. For example in 5G networks, SUCI calculation of 5G SA SIMcard can afftect the network qualiity if it takes too long to response (e.g. not in miliseconds). The connection or the calls can be dropped at the edge of 5G network because handset can swing from 5G to 4G back to 5G network frequently and thus need SUCI response fast enough to maintain the connection.


