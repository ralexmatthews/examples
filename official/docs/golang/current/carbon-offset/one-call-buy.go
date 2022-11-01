package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	toAddress, _ := client.GetAddress("adr_...")
	fromAddress, _ := client.GetAddress("adr_...")
	parcel, _ := client.GetParcel("prcl_...")

	shipment, _ := client.CreateShipmentWithCarbonOffset(
		&easypost.Shipment{
			CarrierAccountIDs: []string{"ca_..."},
			Service:           "NextDayAir",
			Parcel:            parcel,
			ToAddress:         toAddress,
			FromAddress:       fromAddress,
			Reference:         "ShipmentRef",
		},
	)

	fmt.Println(shipment)
}
