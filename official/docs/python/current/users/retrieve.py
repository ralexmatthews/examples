import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

# Retrieve the authenticated user
user = client.user.retrieve_me()

# Retrieve a child user
user = client.user.retrieve("user_...")

print(user)
