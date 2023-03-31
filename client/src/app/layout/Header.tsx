import { AppBar, Toolbar, Typography } from "@mui/material";

export default function Header() {
  return (
    <AppBar position="static" sx={{ mb: 4, bgcolor: "success.main" }}>
      <Toolbar>
        <Typography variant="h6">Green Basket</Typography>
      </Toolbar>
    </AppBar>
  );
}
