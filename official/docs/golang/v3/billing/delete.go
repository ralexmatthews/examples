package example

import (
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	apiKey := os.Getenv("EASYPOST_API_KEY")
	client := easypost.New(apiKey)

	err := client.DeletePaymentMethod(easypost.PrimaryPaymentMethodPriority)

	fmt.Println(err)
}
