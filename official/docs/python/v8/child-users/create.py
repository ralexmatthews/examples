import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

user = client.user.create(name="Child Account Name")

print(user)
