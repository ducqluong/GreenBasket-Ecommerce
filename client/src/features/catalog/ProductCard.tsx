import {
  Button,
  Card,
  CardActions,
  CardContent,
  CardHeader,
  CardMedia,
  Typography,
} from "@mui/material";
import { Product } from "../../app/models/product";

interface Props {
  product: Product;
}

export default function productCard({ product }: Props) {
  return (
    <>
      <Card>
        <CardHeader
          //   avatar={
          //     <Avatar sx={{ bgcolor: "secondary.main" }}>
          //       {product.name.charAt(0).toUpperCase()}{" "}
          //     </Avatar>
          //   }
          title={product.name}
          titleTypographyProps={{
            sx: { fontWeight: "bold", color: "success.light" },
          }}
        />
        <CardMedia
          sx={{ height: 140 }}
          image={product.pictureUrl}
          title={product.name}
        />
        <CardContent>
          <Typography gutterBottom color="success" variant="h5">
            ${product.price}
          </Typography>
          <Typography variant="body2" color="success.secondary">
            {product.brand} / {product.type}
          </Typography>
        </CardContent>
        <CardActions>
          <Button size="small">Add to cart</Button>
          <Button size="small">View</Button>
        </CardActions>
      </Card>
    </>
  );
}
