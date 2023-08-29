package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	shipment, _ := client.GetShipment("shp_...")
	rate, _ := client.LowestShipmentRate(shipment)

	shipment, _ = client.BuyShipmentWithCarbonOffset("shp_...", &rate, "100.00")

	fmt.Println(shipment)
}
